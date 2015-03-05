using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int mask = 1 << 3;
        int maskAndN = number & mask;
        Console.WriteLine(maskAndN >> 3);
    }
}