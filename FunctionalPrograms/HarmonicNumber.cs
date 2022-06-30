using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class HarmonicNumber
    {
        public void HarmonicValue()
        {
            float value = 1;
            Console.WriteLine("Enter N value to find its nth Harmonic value");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n != 0)
            {
                for (float i = 2; i <= n; i++)
                {
                    value = (value + (1 / i));
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("Nth Harmonic value is " + value);
        }
    }
}

