using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter x coordinate: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y coordinate: ");
        double y = Convert.ToDouble(Console.ReadLine());
        bool inCircle = x * x + y * y < 4;
        Console.WriteLine(inCircle);
    }
}