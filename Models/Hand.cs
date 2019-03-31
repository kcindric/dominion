
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Models
{
    public class Hand
    {
        public int Size => _cards.Count;
        public ReadOnlyCollection<ICard> Cards => _cards.AsReadOnly();

        internal IEnumerable<ITreasureCard> TreasureCards
        {
            get
            {
                foreach (ICard c in _cards)
                {
                    if (c is ITreasureCard treasureCard)
                        yield return treasureCard;
                }
            }
        }

        internal IEnumerable<IKingdomCard> KingdomCards
        {
            get
            {
                foreach (ICard c in _cards)
                {
                    if (c is IKingdomCard kingdomCard)
                        yield return kingdomCard;
                }
            }
        }

        private readonly List<ICard> _cards;

        public Hand()
        {
            _cards = new List<ICard>();
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

        internal ICard Remove(ICard card)
        {
            var removed = card;
            _cards.Remove(card);

            return removed;
        }
    }
}
