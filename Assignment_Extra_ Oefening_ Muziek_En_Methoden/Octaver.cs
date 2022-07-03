using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Extra__Oefening__Muziek_En_Methoden
{
    internal class Octaver
    {
        public int IncreaseOctave(int note, int freqmultiplier) 
        {
            if (freqmultiplier != 0)
            {
                for (int i = 0; i < freqmultiplier; i++)
                {
                    note *= 2; // fout in de cursus, harmonie verdubbelt altijd tov het nieuwe cijfer, niet tov het originele
                               // Zie cursus: De octaaf van de toon: 1 = basis octaaf die we al hadden, 2 = 2e octaaf(dus frequentie x2) 3 = 3e octaaf(frequentie x 3) etc.
                }
            }
            return note;
        }
    }
}
