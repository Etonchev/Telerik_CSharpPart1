using System;

class MinMaxSum
{
    static void Main()
    {
        Console.Write("How much numbers:");
        int n = Convert.ToInt32(Console.ReadLine());
        int max = Int32.MinValue;
        int min = Int32.MaxValue;
        int sum = 0;
        double average = 0;
        for (int i = 0; i < n; i++)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > max)
            {
                max = input;
            }
            if (input < min)
            {
                min = input;
            }
            sum += input;
        }
        average = (double)sum / n;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", average);
    }
}