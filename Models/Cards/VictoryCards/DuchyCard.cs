
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Models.Cards.VictoryCards
{
    internal class DuchyCard : IVictoryCard
    {
        public int Points { get; }
        public CardName Name { get; }
        public int Cost { get; }
        public CardType CardType { get; }
        public Player Player { get; set; }

        public DuchyCard(CardName name, int cost, CardType cardType, int points)
        {
            Name = name;
            Cost = cost;
            CardType = cardType;
            Points = points;
        }
    }
}
