using System;

class RandomizeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Random rnd = new Random();
        bool[] printedNumbers = new bool[n + 1];
        for (int i = 0; i < n; i++)
        {
            int number = rnd.Next(1, n + 1);
            if (!printedNumbers[number])
            {
                Console.Write("{0} ", number);
                printedNumbers[number] = true;
            }
            else
            {
                i--;
            }
        }
        Console.WriteLine();
    }
}