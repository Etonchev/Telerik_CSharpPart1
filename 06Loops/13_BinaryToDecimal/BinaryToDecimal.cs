using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();
        ulong decimalNumber = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            int current = (int)Char.GetNumericValue(binary[i]);
            if (current == 1)
            {
                decimalNumber += (ulong)Math.Pow(2, binary.Length - i - 1);
            }
        }
        Console.WriteLine(decimalNumber);
    }
}