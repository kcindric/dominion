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

        internal IEnumerable<IVictoryCard> VictoryCards
        {
            get
            {
                foreach (ICard c in _cards)
                {
                    if (c is IVictoryCard victoryCard)
                        yield return victoryCard;
                }
            }
        }

        public DiscardPile()
        {
            _cards = new List<ICard>();
            _shuffleRandomizer = new Random();
        }

        public DiscardPile Shuffle()
        {
            for (int i = _cards.Count - 1; i >= 0; i--)
            {
                int r = _shuffleRandomizer.Next(0, i);
                ICard temp = _cards[r];
                _cards[r] = _cards[i];
                _cards[i] = temp;
            }

            return this;
        }

        public List<ICard> RemoveAll()
        {
            List<ICard> removedCards = _cards.ToList();
            _cards.Clear();
            return removedCards;
        }

        public void Put(List<ICard> cards)
        {
            _cards.AddRange(cards);
        }

        public void Put(ICard card)
        {
            _cards.Add(card);
        }
    }
}
