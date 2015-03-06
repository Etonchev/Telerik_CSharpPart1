using System;

class BiggestOfFive
{
    static void Main()
    {
        Console.WriteLine("a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("c: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("d: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("e: ");
        int e = Convert.ToInt32(Console.ReadLine());
        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine(c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine(e);
        }
    }
}