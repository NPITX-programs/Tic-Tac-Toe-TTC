using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeProject.DebugCode;

namespace TicTacToeProject
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

            const bool toggleDebug = true; //set to true to open additional debug form
            if (toggleDebug)
            {
                frm_debug debugForm = new frm_debug();
                debugForm.Show();
            }

                using (frmSplashScreen splash = new frmSplashScreen())
            {
                splash.ShowDialog(); // Waits until splash is closed
            }

            Application.Run(new frm_StartMenu()); // Launch main form after splash closes
            

        }
    }
}
