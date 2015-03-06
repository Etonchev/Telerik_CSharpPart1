using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        ulong first = 0;
        ulong second = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}, ", first);
            ulong temp = first + second;
            first = second;
            second = temp;
        }
    }
}