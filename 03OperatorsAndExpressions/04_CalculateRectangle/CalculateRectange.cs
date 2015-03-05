using System;

class CalculateRectange
{
    static void Main()
    {
        Console.Write("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double perimeter = 2 * width + 2 * height;
        double area = width * height;
        Console.WriteLine();
        Console.WriteLine("Perimeter: {0}\nArea: {1}", perimeter, area);
    }
}