using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter min: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter max: ");
        int max = Convert.ToInt32(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rnd.Next(min, max + 1));
        }
    }
}