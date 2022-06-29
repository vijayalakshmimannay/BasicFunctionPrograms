using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class EvenOrOdd
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter a number to find whether it is Even or Odd");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is Even Number", num);
            }
            else
            {
                Console.WriteLine("{0} is Odd Number", num);
            }
        }
    }
}

