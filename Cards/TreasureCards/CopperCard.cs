using Dominion.Cards.Treasure;
using System;

namespace Dominion.Cards.TreasureCards
{
    class CopperCard : ITreasureCard
    {
        public int MoneyValue { get; }
        public CardName Name { get; }
        public int Cost { get; }
        public CardType CardType { get; }
        public Player Player { get; set; }

        public CopperCard(CardName name, int cost, CardType cardType, int moneyValue)
        {
            this.Name = name;
            this.Cost = cost;
            this.CardType = cardType;
            this.MoneyValue = moneyValue;
        }

        public void Play()
        {
            if (this.Player != null)
                this.Player.IncreaseMoney(this.MoneyValue);
            else
                throw new Exception("Card owner not set, cannot be played!");
        }
    }
}
