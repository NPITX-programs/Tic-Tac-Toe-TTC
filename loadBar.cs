using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TicTacToeProject
{
    internal class loadBar
    {
        internal static void LoadBar(ProgressBar progressBar, int max = 100)
        {
            progressBar.Maximum = max;
        } 
    }
}
