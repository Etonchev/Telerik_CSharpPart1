using System;

class PrintAllCards
{
    static void Main()
    {
        string[] cards = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] kinds = { "Clubs", "Diamonds", "Hearts", "Spades" };
        foreach (var card in cards)
        {
            foreach (var kind in kinds)
            {
                Console.WriteLine("{0} of {1}", card, kind);
            }
        }
    }
}