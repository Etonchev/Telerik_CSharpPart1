using System;

class PrintToN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}