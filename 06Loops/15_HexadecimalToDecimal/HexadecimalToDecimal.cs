using System;

class HexadecimalToDecimal
{
    public static int hexToDec(char hex)
    {
        switch (hex)
        {
            case '0':
                return 0;
            case '1':
                return 1;
            case '2':
                return 2;
            case '3':
                return 3;
            case '4':
                return 4;
            case '5':
                return 5;
            case '6':
                return 6;
            case '7':
                return 7;
            case '8':
                return 8;
            case '9':
                return 9;
            case 'A':
                return 10;
            case 'B':
                return 11;
            case 'C':
                return 12;
            case 'D':
                return 13;
            case 'E':
                return 14;
            case 'F':
                return 15;
            default:
                return 0;
        }
    }
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexadecimal = Console.ReadLine();
        long decimalNumber = 0;
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            decimalNumber += hexToDec(hexadecimal[i]) * (long)Math.Pow(16, hexadecimal.Length - i - 1);
        }
        Console.WriteLine(decimalNumber);
    }
}