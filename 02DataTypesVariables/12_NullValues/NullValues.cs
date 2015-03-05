using System;

class NullValues
{
    static void Main()
    {
        int? intVar = null;
        double? doubleVar = null;
        Console.WriteLine(intVar);
        Console.WriteLine(doubleVar);
        intVar += 2;
        doubleVar += 2.5;
        Console.WriteLine(intVar);
        Console.WriteLine(doubleVar);
    }
}
