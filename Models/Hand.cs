
using System.Collections.Generic;
using Dominion.Cards;

namespace Dominion.Models
{
    public class Hand
    {
        public int Size => _cards.Count;
        public List<ICard> Cards => _cards.GetRange(0, _cards.Count);

        private List<ICard> _cards;


        public Hand()
        {
            _cards = new List<ICard>();
        }

        public List<ICard> RemoveAll()
        {
            List<ICard> removedCards = _cards;
            _cards.Clear();
            return removedCards;
        }

        internal void Put(List<ICard> cards)
        {
            _cards.AddRange(cards);
        }
    }
}
