using System;

class BitsExchangeAdvanced
{
    public static int findBit(uint n, int p)
    {
        int mask = 1 << p;
        uint nAndMask = (uint)(n & mask);
        int value = (int)(nAndMask >> p);
        return value;
    }
    public static void flipBit(ref uint n, int p)
    {
        n = (uint)(n ^ (1 << p));
    }

    static void Main()
    {
        Console.WriteLine("Enter number: ");
        uint number = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine("Enter p: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter q: ");
        int q = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            if (findBit(number, p + i) != findBit(number, q + i))
            {
                flipBit(ref number, p + i);
                flipBit(ref number, q + i);
            }
        }

        Console.WriteLine(number);
    }
}
