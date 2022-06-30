using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Factor
    {
        public void Factors()
        {
            Console.WriteLine("Enter a Number to find its Factors");
            int fact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} factors are:", fact);
            for (int i = 2; i < fact; i++)
            {
                while (fact % i == 0)
                {
                    Console.WriteLine(i);
                    fact = fact / i;
                }
            }
            if (fact > 2)
            {
                Console.WriteLine(fact);
            }
        }
    }
}
