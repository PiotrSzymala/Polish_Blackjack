using System;

namespace Oczko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Blakjack - polish version";

            Player player1 = new Player() {Nickname = "Johnny"};
            Player player2 = new Player() {Nickname = "Luke"};
           
            Game.Play(player1);
            Game.Play(player2);
        }
    }
}
