using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    public class FactorialOperation
    {
        public static string CalculateFactorial(int number)
        {
            if (number < 0)
            {
                return "Factorial cannot be calculated for negative numbers.";
            }

            if (number > 15)
            {
                return "Factorial calculation is limited to numbers up to 15.";
            }

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return $"The answer to {number}! is {result}";
        }
    }
}
