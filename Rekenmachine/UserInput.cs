using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    internal class UserInput
    {
        public void AskInput() 
        {
            Calculate calculate = new Calculate();

            Console.Write("Geef het eerste cijfer ");
            Console.Write("[ ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Geef de operator");
            Console.Write("[ ");
            string op = Console.ReadLine();

            Console.Write(" Geef het tweede cijfer");
            Console.Write("[");
            double number2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case "+": calculate.CalculatePlus(number1, number2);
                    break;
                case "-": calculate.CalculateMinus(number1, number2);
                    break;
                case "/": calculate.CalculateDivide(number1, number2);
                    break;
                case "*": calculate.CalculateMultiply(number1, number2);
                    break;
                case "pow": calculate.CalculatePower(number1, number2);
                    break;
                case "sqr": calculate.CalculateRoot(number1 + number2);
                    break;
                default:
                    break;
            }

        }
    }
}
