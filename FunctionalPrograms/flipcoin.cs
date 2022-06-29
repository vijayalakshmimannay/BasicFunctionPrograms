// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class flipcoin
    {
        public void FlipCoin()
        {
            int head = 0, tail = 0, toss, perOfHead, perOfTail;
            Random random = new Random();
            Console.WriteLine("Mention a number to repeat flipping of coin");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                toss = random.Next(0, 2);
                if (toss == head)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }
            perOfHead = (head * 100) / count;
            perOfTail = (tail * 100) / count;
            Console.WriteLine("Heads Percentage is: {0} %", perOfHead);
            Console.WriteLine("Tails Percentage is: {0} %", perOfTail);
        }
    }
}
