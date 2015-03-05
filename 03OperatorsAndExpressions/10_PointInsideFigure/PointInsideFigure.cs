using System;

class PointInsideFigure
{
    static void Main()
    {
        Console.Write("Enter x coordinate: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y coordinate: ");
        double y = Convert.ToDouble(Console.ReadLine());
        bool inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) < 1.5 * 1.5;
        bool inRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
        if (inCircle & !inRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}