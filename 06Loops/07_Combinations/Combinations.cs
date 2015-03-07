using System;

class Combinations
{
    static ulong factorial(int n)
    {
        ulong result = 1;
        while (n > 1)
        {
            result *= (ulong)n;
            n--;
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = Convert.ToInt32(Console.ReadLine());
        ulong result = factorial(n) / (factorial(k) * factorial(n-k));
        Console.WriteLine(result);
    }
}