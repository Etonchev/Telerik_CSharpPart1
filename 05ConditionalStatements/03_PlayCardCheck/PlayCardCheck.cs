using System;

class PlayCardCheck
{
    static void Main()
    {
        Console.WriteLine("Enter card: ");
        string input = Console.ReadLine();
        string[] playCards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "K", "Q", "J"};
        bool isCard = false;
        foreach (var card in playCards)
        {
            if (input == card)
            {
                isCard = true;
                break;
            }
        }
        
        if (isCard)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}