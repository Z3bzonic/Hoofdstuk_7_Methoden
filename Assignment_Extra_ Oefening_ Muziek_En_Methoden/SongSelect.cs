using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Extra__Oefening__Muziek_En_Methoden
{
    internal class SongSelect
    {
        public double SelectSong() 
        {
            double totaletijd = 0;
            Songs song = new Songs();
            if (Console.ReadKey(true).Key == ConsoleKey.A)
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                song.ACDC();
                stopwatch.Stop();
                totaletijd = stopwatch.Elapsed.TotalSeconds;
                Console.Clear();
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.B)
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                song.FurElise();
                stopwatch.Stop();
                totaletijd = stopwatch.Elapsed.TotalSeconds;
                Console.Clear();
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.C)
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                song.Molla();
                stopwatch.Stop();
                totaletijd = stopwatch.Elapsed.TotalSeconds;
                Console.Clear();
            }
            return totaletijd;
        }
    }
}
