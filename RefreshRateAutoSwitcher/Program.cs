using Windows.Win32.Graphics.Gdi;
using static Windows.Win32.PInvoke;
using System.Runtime.InteropServices;
using RefreshRateAutoSwitcher;

namespace RefreshRateAutoSwitcher
{
    internal static class Program
    {
        public static Form1 form1;
        public static DisplaySettings displaySettings;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            displaySettings = new DisplaySettings();
            form1 = new Form1();
            Application.Run(form1);


        }
    }
}