using System;

class AgeAfter
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        byte age = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("You will be {0} years old after 10 years !", age + 10);
    }
}
