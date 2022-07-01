using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    internal class Calculate
    {
        ResultDisplay resultDisplay = new ResultDisplay();
        public void CalculatePlus(double number1, double number2)
        {
            double result = number1 + number2;
            resultDisplay.DisplayResult(result);
        }
        public void CalculateMinus(double number1, double number2)
        {
            double result = number1 - number2;
            resultDisplay.DisplayResult(result);
        }
        public void CalculatePower(double number1, double number2)
        {
            double result = Math.Pow(number1, number2);
            resultDisplay.DisplayResult(result);
        }
        public void CalculateRoot(double number1)
        {
            double result = Math.Sqrt(number1);
            resultDisplay.DisplayResult(result);
        }
        public void CalculateDivide(double number1, double number2)
        {
            double result = number1 / number2;
            resultDisplay.DisplayResult(result);
        }
        public void CalculateMultiply(double number1, double number2)
        {
            double result = number1 * number2;
            resultDisplay.DisplayResult(result);
        }
    }
}
