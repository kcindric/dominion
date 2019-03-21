using Dominion.Cards;
using Dominion.Cards.Factory;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Dominion
{
    public class Deck
    {
        private Random _shuffleRandomizer;
        private Player _player;
        private List<ICard> _cards;

        public int DeckSize {
            get { return _cards.Count; }
        }

        public int TotalCards
        {
            get { return DiscardPile.Count + this._cards.Count + Hand.Count; }
        }

        public int DiscardPileSize { get { return DiscardPile.Count; } }
        public int HandSize { get { return Hand.Count; } }
        public List<ICard> DiscardPile { get; private set; }
        public List<ICard> Hand { get; set; }


        public Deck(Player player)
        {
            _player = player;
            _cards = new List<ICard>();
            Hand = new List<ICard>();
            DiscardPile = new List<ICard>();
            _shuffleRandomizer = new Random();

            for (int i = 0; i < 7; i++)
                this.PutOnto(BigFuckingFactory.TreasureCardFactories[CardName.COPPER].CreateTreasureCard());
            for (int i = 0; i < 3; i++)
                this.PutOnto(BigFuckingFactory.VictoryCardFactories[CardName.ESTATE].CreateVictoryCard());

            this.Shuffle(this._cards);

        }

        private List<ICard> Shuffle(List<ICard> cards)
        {
            for (int i = cards.Count - 1; i == 0; i--)
            {
                int r = _shuffleRandomizer.Next(0, i);
                var temp = cards[r];
                cards[r] = cards[i];
                cards[i] = temp;
            }
            
            return cards;
        }

        private void ReshuffleDiscardPile()
        {
            this._cards.AddRange(this.Shuffle(DiscardPile));
            DiscardPile.Clear();
        }

        public List<ICard> Draw(int n)
        {
            if (this.DeckSize < n)
                this.ReshuffleDiscardPile();

            if (_cards.Count > 0)
            {
                var drawn = new List<ICard>(_cards.Take(n));
                _cards.RemoveRange(0, n);
                return drawn;
            }
            else
                throw new Exception("No cards in deck to draw!");
        }

        public void PutOnto(ICard card)
        {
            this._cards.Insert(0, card);
        }

        public void DrawHand()
        {
            if (Hand == null || Hand.Count == 0)
                Hand = new List<ICard>(Draw(5));
            else
                throw new Exception("Hand not empty, please discard cards first!");
        }

        public void DiscardHand()
        {
            DiscardPile.AddRange(Hand);
            Hand.Clear();
        }
    }
}
