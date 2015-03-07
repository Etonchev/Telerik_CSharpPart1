using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int count = 1;
        for (int i = 1; i < n + 1; i++)
        {
            if (count > 9)
            {
                count = 1;
            }
            for (int j = i + 1; j <= n + i; j++)
            {
                if (count > 9)
                {
                    count = 1;
                }
                Console.Write(count);
                count++;
            }
            Console.WriteLine();
            if (i > 9)
            {
                count = (i - (i / 10) * 10) + 2 + (i / 10);
                //count = (i - (i / 10)*10) + 2; - This will make the program work also for n > 20
            }
            else
            {
                count = i + 1;
            }

        }
    }
}
