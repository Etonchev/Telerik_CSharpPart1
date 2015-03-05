using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter side a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The trapezoid's area is {0}", (float)((a + b) / 2 * height));
    }
}
