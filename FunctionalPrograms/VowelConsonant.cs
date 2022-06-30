using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class VowelConsonant
    {
        public void Alphabet()
        {
            Console.WriteLine("Enter an Alphabet to find whether it is Vowel or Consonant");
            char letter = Convert.ToChar(value: Console.ReadLine().ToLower());
            int i = letter;
            if (i >= 48 && i <= 57)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("{0} is vowel", letter);
            }
            else
            {
                Console.WriteLine("{0} is Consonant", letter);
            }
        }
    }
}
