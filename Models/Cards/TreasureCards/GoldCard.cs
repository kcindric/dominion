﻿
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Models.Cards.TreasureCards
{
    internal class GoldCard : ITreasureCard
    {
        public int MoneyValue { get; }
        public CardName Name { get; }
        public int Cost { get; }
        public CardType CardType { get; }
        public Player Player { get; set; }

        public GoldCard(CardName name, int cost, CardType cardType, int moneyValue)
        {
            Name = name;
            Cost = cost;
            CardType = cardType;
            MoneyValue = moneyValue;
        }
    }
}
