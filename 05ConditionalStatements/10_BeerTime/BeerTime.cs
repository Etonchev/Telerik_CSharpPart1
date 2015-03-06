using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter time");
        DateTime input = DateTime.Parse(Console.ReadLine());
        if (input.Hour >= 3 && input.Hour < 13)
        {
            Console.WriteLine("non-beer time");
        }
        else
        {
            Console.WriteLine("beer time");
        }
    }
}