using System;

class StringAndObjects
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object greeting = first + " " + second;
        string stringGreeting = (string)greeting;
        Console.WriteLine(stringGreeting);
    }
}
