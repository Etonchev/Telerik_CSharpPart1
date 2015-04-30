using System;

class BitsExchange
{
    public static int findBit(int n, int p)
    {
        int mask = 1 << p;
        int nAndMask = n & mask;
        int value = nAndMask >> p;
        return value;
    }
    public static void flipBit(ref int n, int p)
    {
        n = (n ^ (1 << p));
    }

    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (findBit(number, 3) != findBit(number, 24))
        {
            flipBit(ref number, 3);
            flipBit(ref number, 24);
        }

        if (findBit(number, 4) != findBit(number, 25))
        {
            flipBit(ref number, 4);
            flipBit(ref number, 25);
        }

        if (findBit(number, 5) != findBit(number, 26))
        {
            flipBit(ref number, 5);
            flipBit(ref number, 26);
        }

        Console.WriteLine(number);
    }
}
