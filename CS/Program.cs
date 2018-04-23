using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RepEUDRibbonMerging
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
            Application.Run(new RibbonForm1());
        }
    }
}