using System;
using System.Collections.Generic;
using Type = Oczko.Type;

namespace Oczko
{
    internal class Deck
    {
        private static readonly List<Card> CardDeck = new List<Card>()
        {
            new Card {Name = "Two", Type = Type.Two },
            new Card {Name = "Three", Type = Type.Three },
            new Card {Name = "Four", Type = Type.Four },
            new Card {Name = "Five", Type = Type.Five },
            new Card {Name = "Six", Type = Type.Six },
            new Card {Name = "Seven", Type = Type.Seven},
            new Card {Name = "Eight", Type = Type.Eight},
            new Card {Name = "Nine", Type = Type.Nine},
            new Card {Name = "Ten", Type = Type.Ten},
            new Card {Name = "Jack", Type = Type.Jack},
            new Card {Name = "Queen", Type = Type.Queen},
            new Card {Name = "King", Type = Type.King},
            new Card {Name = "Ace", Type = Type.Ace},
        };

        public static List<Card> Generate()
        {
            List<Card> deck = new List<Card>();
            
            for (int i = 0; i < 4; i++)
            {
                foreach (var card in CardDeck)
                {
                    deck.Add(card);
                }
            }
           
            Shuffle(deck);
            
            return deck;
        }

        private static void Shuffle(List<Card> deck)
        {
            Random random = new Random();

            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(0,i+1);

                var temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
    }
}
