using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class randomize
    {
        internal static int coinFlip(bool asBool = false, bool invert = false)
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
            randVal = randVal % 2;
            bool result = true;
            if (randVal == 0) //convert to boolean
            {
                result = false;
            } else
            {
                result = true;
            }

            if(invert)
            {
                result = !!result;
            }

            if(asBool)
            {
                return result;
            } else
            {
                int randNum = 0;
                if(result)
                {
                    randNum = 1;
                }
                else
                {
                    randNum = 0;
                }
                return randNum;
            }
        }
    }
}