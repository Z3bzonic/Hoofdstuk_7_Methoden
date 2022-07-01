using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Film_Default
{
    internal class DisplayRuntime
    {
        public void FilmRuntime(string title, MovieCategory category, int playTime = 90) 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nDe titel van de Film is:\n{title}");
            Console.WriteLine($"De speelduur van de Film is:\n{playTime} minuten");
            Console.WriteLine($"Het genre van de Film is:\n{category}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
