using System;

namespace PolishBlackJack
{
    enum Type
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = Two,
        Queen = Three,
        King = Four,
        Ace = 11
    }
    
    internal class Card : IComparable<Card>
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public int CompareTo(Card other)
        {
            if (other == null)
                return -1;
            return Type.CompareTo(other.Type)==0 ? Name.CompareTo(other.Name) : Type.CompareTo(other.Type);
        }
        public override string ToString() => $"{Name}";
    }
}
