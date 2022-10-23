using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oczko.ShuffleFunctionality
{
    internal class CardShuffler
    {
        private List<Card> _deck;
        private IShuffleDeck _shuffleDeck;

        public CardShuffler(List<Card> deck, IShuffleDeck shuffleDeck)
        {
            _deck = deck;
            _shuffleDeck = shuffleDeck;
        }

        public void Shuffle()
        {
            _shuffleDeck.Shuffle(_deck);
        }
    }
}
