using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class SwapTwoNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Enter first number in swap");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number in swap");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp = num1;
            num1 = num2;
            Console.WriteLine("Output of Swap is {0} {1}", num1, temp);
        }
    }
}

