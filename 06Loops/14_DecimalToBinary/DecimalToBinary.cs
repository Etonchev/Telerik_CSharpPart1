using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string binary = string.Empty;
        while (decimalNumber > 0)
        {
            if (decimalNumber % 2 != 0)
            {
                binary = binary.Insert(0, "1");
            }
            else
            {
                binary = binary.Insert(0, "0");
            }
            decimalNumber /= 2;
        }
        if (binary == string.Empty)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(binary);
        }
    }
}