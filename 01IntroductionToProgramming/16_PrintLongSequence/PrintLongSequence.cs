using System;

class PrintLongSequence
{
    static void Main()
    {
        int alternating = 1;

        for (int i = 2; i < 1002; i++)
        {
            Console.Write("{0}, ", i * alternating);
            alternating *= -1;
        }
    }
}
