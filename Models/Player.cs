using System;
using System.Collections.Generic;
using System.Linq;
using Dominion.Models.Cards.Interfaces;
using Dominion.Models.Cards.Factory;
using Dominion.Models;
using Dominion.Views;

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
        public readonly DiscardPile DiscardPile;

        private readonly List<ICard> _boughtThisTurn;
        public ICard LastBoughtThisTurn => _boughtThisTurn.Last();
        public IEnumerable<ICard> BoughThisTurn => _boughtThisTurn.AsReadOnly(); 


        public Player(string name)
        {
            Name = name;
            Deck = new Deck();
            Hand = new Hand();
            DiscardPile = new DiscardPile();
            _boughtThisTurn = new List<ICard>();
        }

        public Player Setup()
        {
            for (int i = 0; i < 7; i++)
                Deck.PutOnto(BigFuckingFactory.TreasureCardFactories[CardName.COPPER].CreateTreasureCard().SetOwner(this));
            for (int i = 0; i < 3; i++)
                Deck.PutOnto(BigFuckingFactory.VictoryCardFactories[CardName.ESTATE].CreateVictoryCard().SetOwner(this));

            Deck.Shuffle();
            DrawHand();
            return this;
        }

        public void Action(IKingdomCard card)
        {
            Actions--;
            Hand.Remove(card);
            DiscardPile.Put(card);
        }

        public void Buy(ICard card)
        {
            Buys--;
            Money -= card.Cost;
            card.SetOwner(this);
            DiscardPile.Put(card);
            _boughtThisTurn.Add(card);
        }

        public void Cleanup()
        {
            Buys = 1;
            Actions = 1;
            OnTurn = false;
            DiscardHand().DrawHand().CountMoney();
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
            Money = 0;
            foreach (ITreasureCard card in Hand.TreasureCards)
                Money += card.MoneyValue;
        }

        public int CountPoints()
        {
            DiscardPile.Put(Hand.RemoveAll());
            DiscardPile.Put(Deck.RemoveAll());

            int points = 0;
            
            foreach (IVictoryCard c in DiscardPile.VictoryCards)
            {
                    points += c.Points;
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

        public void Gain(ICard card)
        {
            card.SetOwner(this);
            DiscardPile.Put(card);
        }
    }
}
