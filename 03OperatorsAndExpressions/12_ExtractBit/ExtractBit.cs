using System;

class ExtractBit
{
    static void Main()
    {
        //Console.Write("Enter number: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter position: ");
        //int position = Convert.ToInt32(Console.ReadLine());
        //int mask = 1 << position;
        //int maskAndN = number & mask;
        //int bitAtPosition = maskAndN >> position;
        //Console.WriteLine(bitAtPosition);
        int number = 23;
        bool isEven = (number & 1) == 0;
        Console.WriteLine(isEven);
    }
}