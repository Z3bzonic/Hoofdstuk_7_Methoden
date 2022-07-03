using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Extra__Oefening__Muziek_En_Methoden
{
    internal class RythmDivider
    {
        public int DivideRythm(int speed, int tempo) 
        {
            // speed 4 = play full note from tempo convienint for keeping the ints
            int output = 0;

            switch (speed)
            {
                case 1: output = tempo / 32;
                    break;
                case 2:output = tempo / 16;
                    break;
                case 3:output = tempo / 8;
                    break;
                case 4: output = tempo / 4;
                    break;
                case 5:output = tempo / 2;
                    break;
                case 6: output = tempo;
                    break;
                case 7: output = tempo * 2;
                    break;
                case 0:
                default:
                    break;
            }
            return output;
        }
    }
}
