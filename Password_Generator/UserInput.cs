using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    internal class UserInput
    {
        public int GetUserInput() 
        {
            Console.WriteLine("Geef de lengte van het passwoord op");
            int output  = int.Parse(Console.ReadLine());
            return output;
        }
    }
}
