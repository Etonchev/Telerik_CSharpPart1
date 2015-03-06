using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if ((a > b) && (a > c))
            {
                if (b > c)
                {
                    Console.WriteLine("{0} > {1} > {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", a, c, b);
                }
            }
            else if ((b > a) && (b > c))
            {
                if (a > c)
                {
                    Console.WriteLine("{0} > {1} > {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", b, c, a);
                }
            }
            else if ((c > a) && (c > b))
            {
                if (a > b)
                {
                    Console.WriteLine("{0} > {1} > {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", c, b, a);
                }
            }
        }
    }
}

    }
}