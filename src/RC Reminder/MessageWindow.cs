using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RC_Reminder
{
    public partial class MessageWindow : Form
    {
        private string rc_msg;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );

        public MessageWindow(string msg)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            rc_msg = msg;
        }

        private void MessageWindow_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.icon_128;
            label1.Text = rc_msg;

            DragForm dragform = new DragForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
