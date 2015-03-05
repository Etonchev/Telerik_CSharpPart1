using System;

class ExtractBitBool
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = Convert.ToInt32(Console.ReadLine());
        int mask = 1 << position;
        int maskAndN = number & mask;
        int bitAtPosition = maskAndN >> position;
        bool bit = true;
        if (bitAtPosition == 0)
        {
            bit = false;
        }
        Console.WriteLine(bit);
    }
}