using System;

class PrintSequence
{
    static void Main()
    {
        int alternating = 1;
        
        for (int i = 2; i < 12; i++)
        {
            Console.Write("{0}, ", i  * alternating);
            alternating *= -1;
        }
    }
}
