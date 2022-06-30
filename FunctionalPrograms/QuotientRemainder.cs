using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class QuotientRemainder
    {
        public void QuoRem()
        {
            int remainder;
            Console.WriteLine("Enter Divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            int Quotient = Math.DivRem(dividend, divisor, out remainder);
            Console.WriteLine("Quotient is {0}, Remainder is {1}", Quotient, remainder);
        }
    }
}
