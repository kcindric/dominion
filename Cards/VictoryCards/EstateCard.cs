using Dominion.Cards.Victory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.VictoryCards
{
    class EstateCard : IVictoryCard
    {
        public int Points { get; }
        public CardName Name { get; }
        public int Cost { get; }
        public CardType CardType { get; }
        public Player Player { get; set; }

        public EstateCard(CardName name, int cost, CardType cardType, int points)
        {
            this.Name = name;
            this.Cost = cost;
            this.CardType = cardType;
            this.Points = points;
        }
    }
}
