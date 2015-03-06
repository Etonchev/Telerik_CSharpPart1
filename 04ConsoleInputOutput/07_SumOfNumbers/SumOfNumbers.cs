using System;

class SumOfNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split();
        double sum = 0;
        foreach (var item in numbers)
        {
            sum += Convert.ToDouble(item);
        }
        Console.WriteLine(sum);
    }
}