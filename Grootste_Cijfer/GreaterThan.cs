using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grootste_Cijfer
{
    internal class GreaterThan
    {
        public int CheckGreaterThan(int in1, int in2, int in3)
        {
            int grootste = in3;

            if (in1 > in2 && in1 > in3)
            {
                grootste = in1;
            }
            else if (in2 > in3)
            {
                grootste=in2;
            }
            return grootste;
        }
    }
}
