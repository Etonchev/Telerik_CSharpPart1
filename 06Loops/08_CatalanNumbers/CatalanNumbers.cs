using System;

class CatalanNumbers
{
    static ulong factorial(int n)
    {
        ulong result = 1;
        int count = 1;
        while (count <= n)
        {
            result *= (ulong)count;
            count++;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter n for Catalan number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        ulong result = ((factorial(2 * n)) / (factorial(n + 1) * factorial(n)));
        Console.WriteLine(result);
    }
}
