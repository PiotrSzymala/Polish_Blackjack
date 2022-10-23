using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oczko
{
    internal class CardShuffler
    {
        private Deck _deck;

        public CardShuffler(Deck deck)
        {
            _deck = deck;
        }

        internal static void Shuffle(List<Card> deck)
        {
            Random random = new Random();

            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);

                var temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
    }
}
