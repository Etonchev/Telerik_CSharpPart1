using System;

class CalculateNk
{
    static long factorial(int n)
    {
        long result = 1;
        while (n > 1)
        {
            result *= n;
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
        long result = factorial(n) / factorial(k);
        Console.WriteLine(result);
    }
}