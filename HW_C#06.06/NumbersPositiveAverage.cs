using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_06._06
{
    public static class NumbersPositiveAverage 
    {                
        public static double GetAveragePositiveNumbers(this List<int> numbers)
        {
            if(!numbers.Any(x => x > 0))
            {
                throw new NoPositiveNumbersExceptions();
            }            
            return numbers.Where(x => x > 0).Average();
        }
    }
}
    