
using Dominion.Cards;
using Dominion.Cards.Victory;
using System;
using Dominion.Cards.Factory;
using Dominion.Cards.Treasure;
using Dominion.Models;

namespace Dominion
{
    public class Player
    {
        public string Name { get; }

        public int Actions { get; private set; }
        public int Buys { get; private set; }
        public bool OnTurn { get; private set; }
        public int TurnNumber { get; private set; }
        public int Money { get; private set; }

        public double TotalCards => DeckSize + HandSize + DiscardPileSize;
        public double DeckSize => _deck.Size;
        public double HandSize => _hand.Size;
        public double DiscardPileSize => DiscardPile.Size;

        private readonly Deck _deck;
        private readonly Hand _hand;
        public DiscardPile DiscardPile;


        public Player(string name)
        {
            this.Name = name;
            _deck = new Deck();
            _hand = new Hand();
            DiscardPile = new DiscardPile();
        }

        public Player Setup()
        {
            for (int i = 0; i < 7; i++)
                _deck.PutOnto(BigFuckingFactory.TreasureCardFactories[CardName.COPPER].CreateTreasureCard());
            for (int i = 0; i < 3; i++)
                _deck.PutOnto(BigFuckingFactory.VictoryCardFactories[CardName.ESTATE].CreateVictoryCard());

            _deck.Shuffle();

            DrawHand();

            return this;
        }

        public void Action(IKingdomCard card)
        {
            if (Actions > 0)
            {
                Actions--;
                card.Play();
            }
            else
                throw new Exception("No actions remaining!");
        }

        public void Buy(ICard card)
        {
            if (Buys > 0)
            {
                Buys--;

                if (Money >= card.Cost)
                {
                    Money -= card.Cost;
                    card.Player = this;
                }
                else
                    throw new Exception("Not enough money!");
            }
            else
                throw new Exception("No buys remaining!");

        }

        public void Cleanup()
        {
            Money = 0;
            Buys = 0;
            Actions = 0;
            OnTurn = false;
            DiscardHand().DrawHand();
        }

        public void StartTurn()
        {
            OnTurn = true;
            TurnNumber++;
            Actions = 1;
            Buys = 1;
            CountMoney();
        }

        private void CountMoney()
        {
            foreach (ICard card in _hand.Cards)
                Money += ((ITreasureCard) card)?.MoneyValue ?? 0;
        }

        public int CountPoints()
        {
            DiscardPile.Put(_hand.RemoveAll());
            DiscardPile.Put(_deck.RemoveAll());

            int points = 0;
            
            foreach (ICard c in DiscardPile.Cards)
            {
                IVictoryCard vc = (IVictoryCard)c;
                if (vc != null)
                {
                    points += vc.Points;
                }
            }

            return points;
        }

        public Player Draw(int n)
        {
            if (_deck.Size < n)
                this.ReshuffleDiscardPileIntoDeck();

            _hand.Put(_deck.Draw(n));

            return this;
        }

        private Player DrawHand()
        {
            Draw(5);

            return this;
        }

        private Player DiscardHand()
        {
            DiscardPile.Put(_hand.RemoveAll());

            return this;
        }

        private void ReshuffleDiscardPileIntoDeck()
        {
            _deck.PutUnder(DiscardPile.Shuffle().RemoveAll());
        }
    }
}
