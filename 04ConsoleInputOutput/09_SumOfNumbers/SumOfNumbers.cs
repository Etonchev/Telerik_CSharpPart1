using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number [{0}]: ", i);
            double number = Convert.ToDouble(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}