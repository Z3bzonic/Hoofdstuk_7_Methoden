using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Extra__Oefening__Muziek_En_Methoden
{
    internal enum Notes // moeten eigenlijk floats zijn -- de echte frequenties gekozen volgens getemperd klavier afgerond naar dichtste
    {
        // note + N for natural / S for sharps |   except SoS , purpose : avoid clear screen in songPlayer
        Rst,
        DoN = 262,
        DoS = 277,
        ReN = 294,
        ReS = 311,
        MiN = 330,
        FaN = 349,
        FaS = 370,
        Sol = 392,
        SoS = 415,
        LaN = 440,
        LaS = 466,
        SiN = 494,
    }
}
