﻿using System;
using System.Collections.Generic;

using System.Windows.Forms;
//using DevExpress.UserSkins;
//using DevExpress.Skins;
//using DevExpress.LookAndFeel;

namespace ZIZHENG
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

            //BonusSkins.Register();
           // SkinManager.EnableFormSkins();
            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new Main());
        }
    }
}