using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class randomize
    {
        internal static int coinFlip(bool invert = false)
        {
           Random random = new Random();
            int randVal = 0; //intermediary value
            int rand = random.Next(-1, 1); //choose between 3 parts (to spread seed useage
            if(rand == -1)
            {
                randVal = random.Next(0, 100);
            } else if(rand == 0)
            {
                randVal = random.Next(0, 100);
            } else
            {
                randVal = random.Next(0, 100);
            }
            if (invert)
            {
                randVal = randVal + 1; //add one to invert the output
            }

            randVal = randVal % 2;
            return randVal;
        } //coin flip algorithim. To run, use: TicTacToe.randomize.coinFlip()
    }
}