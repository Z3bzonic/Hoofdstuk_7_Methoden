using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    internal class Randomizer
    {
        public char[] MakeRandomPassword(int input) 
        {
            char[] result = new char[input];
            Random random = new Random();

            for (int i = 0; i < input; i++)
            {
                int randomType = random.Next(1, 4);
                switch (randomType)
                {
                    case 4:
                        result[i] = (char)random.Next(33,47);
                        break;
                    case 1:
                        result[i] = (char)random.Next(48,57);
                        break;
                    case 2:
                        result[i] = (char)random.Next(65,90);
                        break;
                    case 3:
                        result[i] = (char)random.Next(97,122);
                        break;
                    default:
                        break;
                }

            }
            return result;
        }
    }
}
