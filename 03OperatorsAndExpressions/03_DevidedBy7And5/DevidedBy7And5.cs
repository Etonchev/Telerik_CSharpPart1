using System;

class DevidedBy7And5
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool devidedBy7And5 = number % 7 == 0 && number % 5 == 0;
        Console.WriteLine(devidedBy7And5);
    }
}