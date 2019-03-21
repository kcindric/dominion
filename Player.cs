
using Dominion.Cards;
using Dominion.Cards.Victory;
using System;
using System.Collections.Generic;
using Dominion.Cards.Treasure;

namespace Dominion
{
    public class Player
    {
        public int Actions { get; private set; }
        public int Buys { get; private set; }
        public bool OnTurn { get; private set; }
        public int TurnNumber { get; private set; }
        public int Money { get; private set; }

        public Deck Deck { get; set; }

        public string Name { get; }

        public Player(string name)
        {
            this.Name = name;
            Deck = new Deck(this);
            Deck.DrawHand();
        }

        internal void IncreaseMoney(int moneyValue)
        {
            Money++;
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
            Deck.DiscardHand();
            Deck.DrawHand();
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
            foreach (ICard card in Deck.Hand)
                ((ITreasureCard)card)?.Play();
        }

        public int CountPoints()
        {
            Deck.Hand.AddRange(Deck.Draw(Deck.TotalCards - Deck.Hand.Count));
            int points = 0;
            
            foreach (ICard c in Deck.Hand)
            {
                IVictoryCard vc = (IVictoryCard)c;
                if (vc != null)
                {
                    points += vc.EvaluateScore();
                }
            }

            return points;
        }
    }
}
