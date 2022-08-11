using System;

namespace Oczko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Blakjack - polish version";
            
            var deck = Deck.Generate();
            int i = 0;
            
            Console.WriteLine("Player #1: ");
            Console.WriteLine("Drawing a card: ");
            Console.WriteLine();
            Game.PlayerTurn(deck, out int sumP1, ref i);

            Console.WriteLine();
            
            Console.WriteLine("Player #2: ");
            Console.WriteLine("Drawing a card: ");
            Console.WriteLine();
            Game.PlayerTurn(deck, out int sumP2, ref i);
            
            Console.Clear();
            Game.Win(sumP1,sumP2);
        }
    }
}
