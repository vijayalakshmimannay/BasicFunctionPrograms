using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class LargestNumber
    {
        public void LargeNum()
        {
            Console.WriteLine("Enter 3 numbers to find the large one");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("{0} is largest number", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("{0} is largest number", num2);
            }
            else
            {
                Console.WriteLine("{0} is largest number", num3);
            }
        }
    }
}
