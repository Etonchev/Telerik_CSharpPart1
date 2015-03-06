using System;

class DividedBy5
{
    static void Main()
    {
        Console.Write("Start = ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("End = ");
        int end = Convert.ToInt32(Console.ReadLine());
        int devisibleBy5 = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                devisibleBy5++;
            }
        }
        Console.WriteLine(devisibleBy5);
    }
}