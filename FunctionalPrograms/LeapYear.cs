using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class LeapYear
    {
        public void LeapYearProg()
        {
            Console.WriteLine("Enter year in 4-digit");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0))
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            if (year % 400 == 0)
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }
        }
    }
}

