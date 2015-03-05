using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool even = number % 2 == 0;
        Console.WriteLine(even);
    }
}
