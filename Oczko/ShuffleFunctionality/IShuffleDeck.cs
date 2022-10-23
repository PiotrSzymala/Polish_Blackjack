using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oczko.ShuffleFunctionality
{
    public interface IShuffleDeck
    {
        void Shuffle(List<Card> deck);
    }
}
