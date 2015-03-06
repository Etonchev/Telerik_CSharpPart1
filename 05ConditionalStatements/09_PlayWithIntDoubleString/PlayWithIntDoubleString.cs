using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.WriteLine("Please enter an int:");
                int varInt = Convert.ToInt32(Console.ReadLine());
                varInt++;
                Console.WriteLine(varInt);
                break;
            case "2":
                Console.WriteLine("Please enter a double:");
                double varDouble = Convert.ToDouble(Console.ReadLine());
                varDouble++;
                Console.WriteLine(varDouble);
                break;
            case "3":
                Console.WriteLine("Please enter a string:");
                string varString = Console.ReadLine();
                varString += "*";
                Console.WriteLine(varString);
                break;
            default:
                Console.WriteLine("Wrong input !");
                break;
        }
    }
}