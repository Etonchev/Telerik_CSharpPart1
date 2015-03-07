using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("n:");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}