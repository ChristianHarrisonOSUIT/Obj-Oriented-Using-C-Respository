using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    public class FibonacciOperation
    {
        public static string CalculateFibonacci(int number)
        {
            if (number < 0)
            {
                return "Fibonacci terms cannot be calculated for negative numbers.";
            }

            if (number > 45)
            {
                return "Fibonacci calculation is limited to terms up to 45.";
            }

            if (number == 0)
            {
                return "Fibonacci(0) = 0";
            }
            else if (number == 1)
            {
                return "Fibonacci(1) = 1";
            }

            int a = 0;
            int b = 1;
            int result = 0;

            for (int i = 2; i <= number; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return $"Fibonacci({number}) = Fibonacci({number - 1}) + Fibonacci({number - 2}) = {result}";
        }
    }
}
