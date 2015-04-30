using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter four digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        if (number < 0)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        Console.WriteLine(isPrime);
    }
}
