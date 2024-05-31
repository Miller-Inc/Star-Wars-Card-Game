﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Star_Wars_Card_Game.Backend.Game;
using Star_Wars_Card_Game.Windows; 

namespace Star_Wars_Card_Game
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpenForm(CurrentForm);
        }

        internal static void OpenForm(OpenForms form)
        {

            if (Properties.Settings.Default.ColorPreference == "Dark") IsDarkMode = true;
            else IsDarkMode = false;

            Classes.FilePath = "Resources\\Classes.json";
            Classes.LoadFromFile(); 

            switch (form)
            {
                case OpenForms.StartupForm:
                    CurrentForm = OpenForms.Quit;
                    Application.Run(new StartupForm());
                    break;
                case OpenForms.Host:
                    CurrentForm = OpenForms.Quit;
                    Application.Run(new Host());
                    break;
                case OpenForms.Join:
                    CurrentForm = OpenForms.Quit;
                    //Application.Run(new Join());
                    break;
                case OpenForms.Game:
                    CurrentForm = OpenForms.Quit;
                    //Application.Run(new Game());
                    break;
                case OpenForms.Quit:
                    CurrentForm = OpenForms.Quit;
                    return;
                default:
                    CurrentForm = OpenForms.Quit;
                    return;
            }

            OpenForm(CurrentForm);
        }

        public static bool IsDarkMode { get; set; } = false;

        public static OpenForms CurrentForm { get; set; } = OpenForms.StartupForm;

    }

    public enum OpenForms
    {
        Quit, 
        StartupForm,
        Host,
        Join,
        Game, 
    }

    public enum ColorPreferences
    {
        Light,
        Dark
    }
}
