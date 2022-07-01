using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Film_Default
{
    internal class UserInput
    {
        public string GetTile() 
        {
            Console.Write("Geef de titel in:");
            string output = Console.ReadLine();
            return output;
        }

        public int GetPlayTime() 
        {
            Console.Write("Geef de speelduur in:");
            int output = int.Parse(Console.ReadLine());
            return output;
        }

        public MovieCategory GetGenre()
        {
            Console.Write("Geef het Genre in:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"({i}) voor {Enum.GetName(typeof(MovieCategory) ,i)}\n");
            }
            int output = int.Parse(Console.ReadLine());
            MovieCategory category = (MovieCategory)output;
            return category;
        }
    }
}
