using System;
using System.Collections.Generic;

namespace Oczko
{
    internal static class Game
    {
        public static void Play(Player player)
        {
            var deck = Deck.Generate();
            int i = 0;
            
            Console.WriteLine($"{player.Nickname} - time to shine!");
            
            do
            {
                Console.WriteLine(deck[i]);

                player.Points += (int)deck[i].Type;

                if (EarlyWinOrLose(player.Points))
                    break;

                Console.WriteLine("Would you like to draw another card? Press n or escape to stop");

                i++;

            } while (KeyExit());

            Console.Clear();

            Console.WriteLine($"{player.Nickname} points: {player.Points}");

            Console.ReadKey();
            Console.Clear();
        }

        private static bool EarlyWinOrLose(int points)
        {
            if (points == 21)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{points} - Blackjack, you won!");
                Console.ResetColor();
                Console.ReadKey();
                return true;
            }

            if (points >= 22)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{points} - Too much, you lost!");
                Console.ResetColor();
                Console.ReadKey();
                return true;
            }

            return false;
        }

        private static bool KeyExit()
        {
            ConsoleKeyInfo userKey = Console.ReadKey(true);
            switch (userKey.Key)
            {
                case ConsoleKey.N:
                case ConsoleKey.Escape:
                    return false;
            }

            return true;
        }
    }
}
