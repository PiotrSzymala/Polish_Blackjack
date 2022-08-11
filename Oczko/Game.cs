using System;
using System.Collections.Generic;

namespace Oczko
{
    internal static class Game
    {
        public static void PlayerTurn(List<Card> deck, out int sum, ref int i)
        {
            sum = 0;
            string userInput;

            do
            {
                Console.WriteLine(deck[i]);
                sum += (int)deck[i].Type;

                if (EarlyWinOrLose(sum))
                    break;

                Console.WriteLine("Would you like to draw another card? y / n");
                userInput = Console.ReadLine();

                i++;

            } while (Escape(userInput));

            Console.Clear();
        }

        static bool Escape(string userInput)
        {
            return userInput.ToLower() != "n";
        }

        private static bool EarlyWinOrLose(int sum)
        {
            if (sum == 21)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{sum} - Blackjack, you won!");
                Console.ResetColor();
                Console.ReadKey();
                return true;
            }

            if (sum < 22) return false;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{sum} - Too much, you lost!");
            Console.ResetColor();
            Console.ReadKey();

            return true;

        }

        public static void Win(int p1Score, int p2Score)
        {
            string score;

            Console.WriteLine($"Player #1 score: {p1Score}");
            Console.WriteLine($"Player #2 score: {p2Score}");
            
            if (p1Score > 22 && p2Score > 22)
                score = "There is no winner";
            
            else if (p1Score < 22 && p2Score < 22)
                score = Math.Max(p1Score, p2Score) == p1Score ? "Player #1 is the winner" : "Player #2 is the winner";

            else if (p1Score == p2Score)
                score = "Draw";

            else
                score = Math.Min(p1Score, p2Score) == p1Score ? "Player #1 is the winner" : "Player #2 is the winner";

            Console.ForegroundColor = ConsoleColor.Yellow;
           
            Console.WriteLine();
            Console.WriteLine(score);
           
            Console.ResetColor();
        }
    }
}
