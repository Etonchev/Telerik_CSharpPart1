using System;
class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter third number: ");
        double third = Convert.ToDouble(Console.ReadLine());
        double sum = first + second + third;
        Console.WriteLine(sum);
    }
}
