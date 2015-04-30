using System;
class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("first value: ");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.Write("second value: ");
        double second = Convert.ToDouble(Console.ReadLine());
        if (first > second)
        {
            double temp = first;
            first = second;
            second = temp;
        }

        Console.WriteLine("{0}, {1}", first, second);
    }
}