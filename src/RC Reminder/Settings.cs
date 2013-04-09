using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RC_Reminder
{
    public static class Settings
    {
        /// <summary>
        /// USER_PROFILE/AppData/Roaming/RCReminder/settings
        /// </summary>
        private static string settings_dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\RCReminder\\";
        private static string settings_file = settings_dir + "settings";

        public static int time;
        public static string message;
        public static int notifytype;
        public static bool startuplaunch;

        /// <summary>
        /// Default settings
        /// </summary>
        public static void Default()
        {
            time = 30;
            message = "Are you dreaming? Do a reality check!";
            notifytype = 2;
            startuplaunch = false;
        }

        /// <summary>
        /// Write settings
        /// </summary>
        public static void Save()
        {
            if(!Directory.Exists(settings_dir))
                try
                {
                    Directory.CreateDirectory(settings_dir);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Error creating settings directory");
                }

            try
            {
                using (StreamWriter w = new StreamWriter(settings_file, false))
                {
                    w.WriteLine(string.Format("time={0}", time));
                    w.WriteLine(string.Format("message={0}", message));
                    w.WriteLine(string.Format("notifytype={0}", notifytype));
                    w.WriteLine(string.Format("startup={0}", startuplaunch));
                    w.Flush();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error saving settings");
            }
        }

        /// <summary>
        /// Loads the settings
        /// If the settings file cannot be found, load default settings
        /// </summary>
        public static void Load()
        {
            Default();

            if (File.Exists(settings_file))
            {
                using (StreamReader r = new StreamReader(settings_file))
                {
                    while (r.Peek() >= 0)
                    {
                        string line = r.ReadLine();

                        if (line.Contains("="))
                        {
                            string[] split = line.Split('=');
                            Parse(split[0], split[1]);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Parses the name of the setting with the value
        /// </summary>
        /// <param name="n"></param>
        /// <param name="v"></param>
        private static void Parse(string n, string v)
        {
            switch (n)
            {
                case "time":
                    
                    if(!int.TryParse(v, out time))
                        time = 30;

                    break;
                case "message":

                    message = v;

                    break;
                case "notifytype":

                    if (!int.TryParse(v, out notifytype))
                        notifytype = 2;

                    break;
                case "startup":

                    if (!bool.TryParse(v, out startuplaunch))
                        startuplaunch = false;

                    break;
            }
        }
    }
}
