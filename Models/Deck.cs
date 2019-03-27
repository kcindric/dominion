using System;
using System.Collections.Generic;
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Models
{
    public class Deck
    {
        private Random _shuffleRandomizer;
        private List<ICard> _cards;

        public int Size => _cards.Count;


        public Deck()
        {
            _cards = new List<ICard>();
            _shuffleRandomizer = new Random();
        }

        public Deck Shuffle()
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

        public Deck PutOnto(ICard card)
        {
            this._cards.Insert(0, card);
            return this;
        }

        public Deck PutOnto(List<ICard> cards)
        {
            this._cards.InsertRange(0, cards);
            return this;
        }

        public Deck PutUnder(List<ICard> cards)
        {
            _cards.AddRange(cards);
            return this;
        }

        public List<ICard> Draw(int i)
        {
            List<ICard> drawnCards = _cards.GetRange(0,_cards.Count < i ? _cards.Count : i);
            _cards.RemoveRange(0, drawnCards.Count);
            return drawnCards;
        }

        public List<ICard> RemoveAll()
        {
            List<ICard> removedCards = _cards;
            _cards.Clear();
            return removedCards;
        }
    }
}
