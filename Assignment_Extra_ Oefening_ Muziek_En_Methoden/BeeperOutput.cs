using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Extra__Oefening__Muziek_En_Methoden
{
    internal class BeeperOutput
    {
        // Imagine I gave all 12 notes their method and did the exact same thing -- zie opdracht
        public void PlayNote(int pitch, int speed) 
        {
            if (pitch != 0)
            {
                Console.Beep(pitch, speed);
            }
            else 
            {
                Thread.Sleep(speed);
            }
        }
    }
}
