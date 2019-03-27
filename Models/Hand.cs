
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Models
{
    public class Hand
    {
        public int Size => _cards.Count;
        public ReadOnlyCollection<ICard> Cards => _cards.AsReadOnly();

        private readonly List<ICard> _cards;

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

        public void Put(List<ICard> cards)
        {
            _cards.AddRange(cards);
        }
    }
}
