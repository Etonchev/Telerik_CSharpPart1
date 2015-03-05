using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value: ");
        int value = Convert.ToInt32(Console.ReadLine());
        if (value == 1)
        {
            int mask = 1 << position;
            number = number | mask;
        }
        else
        {
            int mask = ~(1 << position);
            number = number & mask;
        }
        Console.WriteLine(number);
    }
}