using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RC_Reminder
{
    public partial class Main : Form
    {
        private bool enabled = false;
        private int msg_delay;

        public bool ReminderStatus
        {
            get { return enabled; }
            set { enabled = value; }
        }

        /// <summary>
        /// Save user settings when the application exists
        /// </summary>
        public Main()
        {
            InitializeComponent();
            FormClosing += (s, e) =>
                {
                    Settings.Load();
                    SaveSettings();
                };
        }

        /// <summary>
        /// Load the settings and apply to the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            this.Icon = BitmapToIcon.Create(Properties.Resources.icon_128);

            Taskbar.mainForm = this;
            Taskbar.Update();

            Settings.Load();
            ApplySettings();
        }

        /// <summary>
        /// Save settings
        /// </summary>
        private void SaveSettings()
        {
            try
            {
                Settings.time = int.Parse(cbTime.Text);
            }
            catch
            {
                MessageBox.Show("Time is in bad format");
                cbTime.Text = "30";
            }

            Settings.message = txtMessage.Text;
            Settings.notifytype = radioTypeTaskbar.Checked ? 1 : 2;
            Settings.startuplaunch = cbStartup.Checked;
            Settings.Save();
            LaunchStartup.Set(Settings.startuplaunch);
        }

        /// <summary>
        /// Apply loaded settings
        /// </summary>
        private void ApplySettings()
        {
            cbTime.Text = Settings.time.ToString();
            txtMessage.Text = Settings.message;

            if (Settings.notifytype == 1)
                radioTypeTaskbar.Checked = true;
            else
                radioTypeMsgBox.Checked = true;

            cbStartup.Checked = Settings.startuplaunch;
        }

        /// <summary>
        /// Notify the user that the program is running in the background/taskbar
        /// </summary>
        public void RunningInBackground()
        {
            Taskbar.Balloon("Reality Check Reminder", "RC Reminder is running in the background", ToolTipIcon.Info, 5000);
        }

        /// <summary>
        /// Enable/disable the reality check reminder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Toggle(object sender, EventArgs e)
        {
            ToggleReminder();
        }
        public void ToggleReminder()
        {
            if (enabled)
            {
                btnToggle.Text = "Enable";
            }
            else
            {
                btnToggle.Text = "Disable";
                msg_delay = int.Parse(cbTime.Text) * 60;


                Thread timerThread = new Thread(new ThreadStart(TimerThread));
                timerThread.Start();
            }

            enabled = enabled ? false : true;
            Taskbar.Refresh();

            if(enabled)
                Taskbar.Balloon("Reality Check", "You will be reminded every " + cbTime.Text + " minutes", ToolTipIcon.Info, 5000);
        }

        /// <summary>
        /// Thread method used as a timer. When the timer reaches the time, it will display a message box
        /// or a taskbar balloon depending on the user options.
        /// 
        /// If the MessageWindow is already visible when the timer reaches the time again, it will not display.
        /// </summary>
        private bool msgBoxIsVisible = false;
        private void TimerThread()
        {
            int current = 1;

            while (enabled)
            {
                if (current == msg_delay)
                {
                    if (radioTypeTaskbar.Checked)
                        Taskbar.Balloon("Reality Check", txtMessage.Text, ToolTipIcon.None, 10000);
                    else if(!msgBoxIsVisible)
                        DisplayMsgWin();

                    current = 1;
                }

                Thread.Sleep(1000);
                current++;
            }
        }

        /// <summary>
        /// Display the MessageWindow
        /// </summary>
        delegate void DisplayMsgWinDelegate();
        private void DisplayMsgWin()
        {
            if (InvokeRequired)
                Invoke(new DisplayMsgWinDelegate(DisplayMsgWin));
            else
            {
                MessageWindow msgwin = new MessageWindow(txtMessage.Text);

                msgBoxIsVisible = true;
                msgwin.ShowDialog(this);
                msgBoxIsVisible = false;
            }

        }

        /// <summary>
        /// Set default settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelDefault_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings.Default();
            ApplySettings();
        }
    }
}
