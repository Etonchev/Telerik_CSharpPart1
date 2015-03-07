using System;

class OddOrEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] array = input.Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < array.Length; i++)
        {
            int number = Convert.ToInt32(array[i]);
            if (i % 2 == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}