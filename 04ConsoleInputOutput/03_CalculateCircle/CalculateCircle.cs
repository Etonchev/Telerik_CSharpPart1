using System;

class CalculateCircle
{
    static void Main()
    {
        Console.Write("Enter radius of the circle: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double area = r * Math.PI * Math.PI;
        double perimeter = 2 * r * Math.PI;
        Console.WriteLine("The area is {0:0.00} and the perimeter is {1:0.00}", area, perimeter);
    }
}