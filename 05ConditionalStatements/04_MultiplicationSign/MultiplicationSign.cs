using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("first: ");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("second: ");
        double second = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("third: ");
        double third = Convert.ToDouble(Console.ReadLine());
        int negativeCount = 0;
        if (first < 0)
        {
            negativeCount++;
        }
        if (second < 0)
        {
            negativeCount++;
        }
        if (third < 0)
        {
            negativeCount++;
        }
        if (first == 0 || second == 0 || third == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (negativeCount == 1 || negativeCount == 3)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}