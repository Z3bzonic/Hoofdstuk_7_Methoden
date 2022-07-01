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
            string outputTitle = Console.ReadLine();
            return outputTitle;
        }

        public int GetPlayTime() 
        {
            Console.Write("Geef de speelduur in minuten:");
            string input = Console.ReadLine();
            int outputPlayTime = 0;
            if (input != "")
            {
                outputPlayTime = int.Parse(input);
            }
            return outputPlayTime;
        }

        public MovieCategory GetGenre()
        {
            Console.Write("Geef het Genre in:");
            int enumCount = Enum.GetNames(typeof(MovieCategory)).Length;
            int outputGenre = 0;
            for (int i = 0; i < enumCount; i++)
            {
                Console.Write($"({i}) voor {Enum.GetName(typeof(MovieCategory) ,i)}\n");
            }
            string input = Console.ReadLine();
            if (input != "")
            {
                outputGenre = int.Parse(input);
            }

            MovieCategory category = (MovieCategory)outputGenre;
            return category;
        }
    }
}
