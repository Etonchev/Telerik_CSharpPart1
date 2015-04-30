using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c = ");
        double c = Convert.ToDouble(Console.ReadLine());
        double discriminant = b * b - 4 * a * c;
        double x1 = 0;
        double x2 = 0;
        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (discriminant == 0)
        {
            x1 = -b / (2 * a);
            x2 = -b / (2 * a);
        }
        else
        {
            x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
        }

        Console.WriteLine("x1={0}; x2={1}", x1, x2);
    }
}