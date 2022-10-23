using System;

namespace Oczko
{

    public class Card : IComparable<Card>
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
