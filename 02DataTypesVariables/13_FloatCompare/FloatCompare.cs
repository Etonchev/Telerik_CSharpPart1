using System;

class FloatCompare
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter precision: ");
        double eps = Convert.ToDouble(Console.ReadLine());

        bool compare = true;
        if (Math.Abs(first - second) >= eps)
        {
            compare = false;
        }
        Console.WriteLine(compare);
    }
}
