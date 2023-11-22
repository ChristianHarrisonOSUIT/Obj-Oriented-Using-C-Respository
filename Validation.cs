using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    public static class Validation
    {
        public static bool IsValidInteger(string input, int minValue, int maxValue)
        {
            if (int.TryParse(input, out int number))
            {
                return number >= minValue && number <= maxValue;
            }
            return false;
        }
    }
}
