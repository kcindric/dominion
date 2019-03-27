using System;
using Dominion.Models.Cards.Interfaces;
using Dominion.Models.Cards.Factory;
using Dominion.Models;

namespace Dominion.Models
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
        public double DeckSize => Deck.Size;
        public double HandSize => Hand.Size;
        public double DiscardPileSize => DiscardPile.Size;

        public readonly Deck Deck;
        public readonly Hand Hand;
        public DiscardPile DiscardPile;


        public Player(string name)
        {
            Name = name;
            Deck = new Deck();
            Hand = new Hand();
            DiscardPile = new DiscardPile();
        }

        public Player Setup()
        {
            for (int i = 0; i < 7; i++)
                Deck.PutOnto(BigFuckingFactory.TreasureCardFactories[CardName.COPPER].CreateTreasureCard());
            for (int i = 0; i < 3; i++)
                Deck.PutOnto(BigFuckingFactory.VictoryCardFactories[CardName.ESTATE].CreateVictoryCard());

            Deck.Shuffle();
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
            foreach (ICard card in Hand.Cards)
                Money += ((ITreasureCard) card)?.MoneyValue ?? 0;
        }

        public int CountPoints()
        {
            DiscardPile.Put(Hand.RemoveAll());
            DiscardPile.Put(Deck.RemoveAll());

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
            if (Deck.Size < n)
                this.ReshuffleDiscardPileIntoDeck();

            Hand.Put(Deck.Draw(n));

            return this;
        }

        private Player DrawHand()
        {
            Draw(5);

            return this;
        }

        private Player DiscardHand()
        {
            DiscardPile.Put(Hand.RemoveAll());

            return this;
        }

        private void ReshuffleDiscardPileIntoDeck()
        {
            Deck.PutUnder(DiscardPile.Shuffle().RemoveAll());
        }
    }
}
