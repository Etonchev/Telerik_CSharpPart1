using System;

class MoonGravitation
{
    static void Main()
    {
        Console.Write("Enter weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your weight on the moon would be {0:0.000} kg !", 0.17f * weight);
    }
}
