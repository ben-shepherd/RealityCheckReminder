using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace RC_Reminder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }

    public static class BitmapToIcon
    {
        public static Icon Create(Bitmap bm)
        {
            bm.MakeTransparent(Color.White);
            IntPtr ich = bm.GetHicon();

            return Icon.FromHandle(ich);
        }
    }

    public static class LaunchStartup
    {
        private static string urlFile = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\Reality Check Reminder.url";

        public static void Set(bool startup)
        {
            if (startup)
                ShortcutUrl();
            else
                if(File.Exists(urlFile))
                    try
                    {
                        File.Delete(urlFile);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error deleting shortcut file\r\n'"+urlFile+"'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
        }

        private static void ShortcutUrl()
        {
            try
            {
                using (StreamWriter w = new StreamWriter(urlFile, false))
                {
                    w.WriteLine("[InternetShortcut]");
                    w.WriteLine("URL=file:///" + Application.ExecutablePath);
                    w.WriteLine("IconIndex=0");
                    w.WriteLine("IconFile=" + Application.ExecutablePath.Replace('\\', '/'));
                    w.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating startup file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class DragForm
    {
        private Form form;
        private bool mouse_down = false;
        private Point touchPoint;

        public DragForm(Form _form)
        {
            form = _form;
            form.MouseDown += new MouseEventHandler(form_MouseDown);
            form.MouseMove += new MouseEventHandler(form_MouseMove);
            form.MouseUp += new MouseEventHandler(form_MouseUp);
        }

        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_down = true;
            touchPoint = e.Location;
        }

        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouse_down)
                form.Location = new Point(Cursor.Position.X - touchPoint.X, Cursor.Position.Y - touchPoint.Y);
        }

        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }
    }
}
