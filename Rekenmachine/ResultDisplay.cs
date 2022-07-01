using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    internal class ResultDisplay
    {
        public void DisplayResult(double input) 
        {
            if ((input%1)/input == 1)
            {
                Console.WriteLine($"{Math.Round(input, 0)}");
            }
            Console.WriteLine($"{Math.Round(input, 2)}");
        }
    }
}
