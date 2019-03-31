﻿
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Models.Cards.VictoryCards
{
    internal class CurseCard : IVictoryCard
    {
        public int Points { get; }
        public CardName Name { get; }
        public int Cost { get; }
        public CardType CardType { get; }
        public Player Player { get; set; }

        public CurseCard(CardName name, int cost, CardType cardType, int points)
        {
            Name = name;
            Cost = cost;
            CardType = cardType;
            Points = points;
        }
    }
}
