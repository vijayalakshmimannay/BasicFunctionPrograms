using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class PowerOfTwo
    {
        public void Power()
        {
            int output = 1;
            Console.WriteLine("Enter a value for n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n <= 31)
            {
                for (int i = 1; i <= n; i++)
                {
                    output = output * 2;
                    Console.WriteLine("Two power {0} is {1}", i, output);
                }
            }
            else
            {
                Console.WriteLine("Select Number between 0 to 31");
            }
        }
    }
}
