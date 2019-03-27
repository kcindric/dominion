using System;
using System.Collections.Generic;
using System.Linq;
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Models
{
    public class DiscardPile
    {
        private readonly Random _shuffleRandomizer;
        private readonly List<ICard> _cards;

        public int Size => _cards.Count;
        public IEnumerable<ICard> Cards => _cards.AsReadOnly();

        public DiscardPile()
        {
            _cards = new List<ICard>();
            _shuffleRandomizer = new Random();
        }

        public DiscardPile Shuffle()
        {
            for (int i = _cards.Count - 1; i == 0; i--)
            {
                int r = _shuffleRandomizer.Next(0, i);
                var temp = _cards[r];
                _cards[r] = _cards[i];
                _cards[i] = temp;
            }

            return this;
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
