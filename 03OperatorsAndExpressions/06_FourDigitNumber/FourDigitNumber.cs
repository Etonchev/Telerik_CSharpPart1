using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter four digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 1000 || number > 9999)
        {
            throw new IndexOutOfRangeException();
        }
        int firstDigit = number / 1000;
        int secondDigit = number / 100 % 10;
        int thirdDigit = number / 10 % 10;
        int fourthDigit = number % 10;

        Console.WriteLine("Sum of digits " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
        Console.WriteLine("Number im reverse order: " + fourthDigit + thirdDigit + secondDigit + firstDigit);
        Console.WriteLine("Number with las digit in front: " + fourthDigit + firstDigit + secondDigit + thirdDigit);
        Console.WriteLine("Number with exchanged second and third digit: " + firstDigit + thirdDigit + secondDigit + fourthDigit);
    }
}