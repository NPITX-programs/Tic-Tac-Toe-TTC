using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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


            using (frmSplashScreen splash = new frmSplashScreen())
            {
                splash.ShowDialog(); // Waits until splash is closed
            }

            Application.Run(new StartMenu()); // Launch main form after splash closes

        }
        TicTacToeProject.ticTacToe.
    }
}
