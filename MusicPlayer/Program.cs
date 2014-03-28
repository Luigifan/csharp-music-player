using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utility.ModifyRegistry;

namespace MusicPlayer
{
    static class Program
    {
        

        public static InitialMusicPicking InitialMusicPicking
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public static MainForm MainForm
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ModifyRegistry mr = new ModifyRegistry();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (mr.Read("HASSETUP") == "true")
            {
                MainForm mf = new MainForm();
                mf.Show();

            }
            else
            {
                InitialMusicPicking imp = new InitialMusicPicking();
                imp.Show();
                
            }
            Application.Run();
        }
    }
}
