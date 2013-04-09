using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace RC_Reminder
{
    public static class Taskbar
    {
        public static Main mainForm;
        public static bool WindowHidden = false;
        private static NotifyIcon icon;
        private static ContextMenu cmenu;

        public static void Update()
        {
            icon = new NotifyIcon();
            cmenu = new ContextMenu();

            cmenu.MenuItems.Add((mainForm.ReminderStatus ? "Disable" : "Enable")+" reminder").Click += (s, e) =>
                {
                    mainForm.ToggleReminder();
                };
            cmenu.MenuItems.Add("-");
            cmenu.MenuItems.Add(WindowHidden ? "Show" : "Hide").Click += (s, e) =>
                {
                    if (WindowHidden)
                    {
                        mainForm.Show();
                    }
                    else
                        mainForm.Hide();

                    WindowHidden = WindowHidden ? false : true;

                    if (WindowHidden)
                        mainForm.RunningInBackground();

                    Taskbar.Refresh();
                };
            cmenu.MenuItems.Add("-");
            cmenu.MenuItems.Add("Exit").Click += (s, e) =>
                {
                    Taskbar.Remove();
                    mainForm.ReminderStatus = false;

                    Environment.Exit(0);
                };

            icon.ContextMenu = cmenu;
            icon.Icon = BitmapToIcon.Create(Properties.Resources.icon_128);
            icon.Visible = true;
        }
        public static void Refresh()
        {
            icon.Dispose();
            Taskbar.Update();
        }
        public static void Remove()
        {
            icon.Visible = false;
            icon.Dispose();
            icon = null;
        }
        public static void Balloon(string title, string text, ToolTipIcon tt_icon, int display_duration)
        {
            icon.BalloonTipTitle = title;
            icon.BalloonTipText = text;
            icon.BalloonTipIcon = tt_icon;
            icon.ShowBalloonTip(display_duration);
        }
    }
}
