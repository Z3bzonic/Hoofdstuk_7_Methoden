using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.ComponentModel;


namespace Assignment_Extra__Oefening__Muziek_En_Methoden
{
    internal class AsyncSoundsLoader
    {
        public void LoadSounds() 
        {
            // ik wou SoundPlayer Method gebruiken maar ik kreeg het niet klaar en ik wist ook niet hoe een nugget packet te filteren
            // om async alle noten in sinus(noot).wav in te laden. 
            // Reden --> de huidige hardware voor de beeper aan te sturen slaat volledig tilt indien het te snel gaat waardoor ik op een
            // single thread geen polyfonie kan 'faken'
            // ik wou dus async alles inladen - afspelen - pauzeren en resumen aan de hand van instelbare timing adhv variabele tempo
        }
    }
}
