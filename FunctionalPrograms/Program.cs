Console.WriteLine("1. Flip Coin\n2. Leap Year\n3. Power of 2\n4. Harmonic Value\n5. Factors\n6. Quotient and Remainder\n7. Swap Two Numbers\n8. Even or Odd\n9. Vowel or Consonant\n10. Largest Number");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        FunctionalPrograms.flipcoin output = new FunctionalPrograms.flipcoin();
        output.FlipCoin();
        break;
    case 2:
        FunctionalPrograms.LeapYear year = new FunctionalPrograms.LeapYear();
        year.LeapYearProg();
        break;
    case 3:
        FunctionalPrograms.PowerOfTwo power = new FunctionalPrograms.PowerOfTwo();
        power.Power();
        break;
    case 4:
        FunctionalPrograms.HarmonicNumber harmonic = new FunctionalPrograms.HarmonicNumber();
        harmonic.HarmonicValue();
        break;
    case 5:
        FunctionalPrograms.Factor factors = new FunctionalPrograms.Factor();
        factors.Factors();
        break;
    case 6:
        FunctionalPrograms.QuotientRemainder quotient = new FunctionalPrograms.QuotientRemainder();
        quotient.QuoRem();
        break;
    case 7:
        FunctionalPrograms.SwapTwoNumbers swap = new FunctionalPrograms.SwapTwoNumbers();
        swap.Swap();
        break;
    case 8:
        FunctionalPrograms.EvenOrOdd number = new FunctionalPrograms.EvenOrOdd();
        number.EvenOdd();
        break;
    case 9:
        FunctionalPrograms.VowelConsonant alphabet = new FunctionalPrograms.VowelConsonant();
        alphabet.Alphabet();
        break;
    case 10:
        FunctionalPrograms.LargestNumber largest = new FunctionalPrograms.LargestNumber();
        largest.LargeNum();
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}