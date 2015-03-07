using System;

class NotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("n:");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}