using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int larger = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int smaller = Convert.ToInt32(Console.ReadLine());
        if (smaller > larger)
        {
            larger = larger + smaller;
            smaller = larger - smaller;
            larger = larger - smaller;
        }

        int remainder = larger % smaller;
        int number = smaller;
        while (remainder != 0)
        {
            int temp = remainder;
            remainder = number % remainder;
            number = temp;
        }
        Console.WriteLine(number);
    }
}