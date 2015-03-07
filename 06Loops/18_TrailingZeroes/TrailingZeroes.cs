using System;

class NumberOfTrailingZeros
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            int divider = i;
            while (divider % 5 == 0)
            {
                count++;
                divider /= 5;
            }
        }

        Console.WriteLine(count);
    }
}
