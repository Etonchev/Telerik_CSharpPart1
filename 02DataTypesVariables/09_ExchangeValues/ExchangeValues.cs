using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before a = {0}, b = {1}", a, b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After a = {0}, b = {1}", a, b);
    }
}
