using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominion.Cards;

namespace Dominion.Models
{
    public class DiscardPile
    {
        private Random _shuffleRandomizer;
        private List<ICard> _cards;

        public int Size => _cards.Count;

        public List<ICard> Cards
        {
            get { return _cards.GetRange(0, _cards.Count()); }
        }

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

        internal void Put(List<ICard> cards)
        {
            _cards.AddRange(cards);
        }
    }
}
