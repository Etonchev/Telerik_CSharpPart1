using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool thirdDigitIs7 = number / 100 % 10 == 7;
        Console.WriteLine(thirdDigitIs7);
    }
}
