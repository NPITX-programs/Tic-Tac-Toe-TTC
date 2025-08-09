using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    internal class randomize
    {
        internal static int coinFlip(bool invert)
        {
           Random random = new Random();
            int rand = random.Next(-1, 1);
            return rand;
        }
    }
}