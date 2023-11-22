using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    public class ModulusOperation
    {
        public static string CalculateModulus(int dividend, int divisor)
        {
            int quotient = 0;
            int remainder = dividend;

            while (remainder >= divisor)
            {
                remainder -= divisor;
                quotient++;
            }

            return $"{dividend} divided by {divisor} is {quotient} with a remainder of {remainder}";
        }
    }
}
