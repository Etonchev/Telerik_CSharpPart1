using System;

class CalculateSum
{
    static long factorial(int n)
    {
        long result = 1;
        while (n > 1)
        {
            result *= n;
            n--;
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("n:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x:");
        int x = Convert.ToInt32(Console.ReadLine());
        double sum = 1;
        int count = 1;
        while (count <= n)
        {
            sum += (factorial(count)) / (Math.Pow(x, count));
            count++;
        }

        Console.WriteLine("{0:0.00000}", sum);
    }
}
