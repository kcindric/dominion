using System;
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Models.Cards.KingdomCards
{
    public class ArtisanCard : IKingdomCard
    {
        public string CardText { get; }
        public CardName Name { get; }
        public int Cost { get; }
        public CardType CardType { get; }
        public Player Player { get; set; }

        public ArtisanCard(CardName name, int cost, CardType cardType, string cardText)
        {
            this.Name = name;
            this.Cost = cost;
            this.CardType = cardType;
            this.CardText = cardText;
        }

        public void Play()
        {
            GainCardWorthUpTo5();
            PutCardFromHandOntoDeck();
        }

        private void PutCardFromHandOntoDeck()
        {
            throw new NotImplementedException();
        }

        private void GainCardWorthUpTo5()
        {
            throw new NotImplementedException();
        }
    }
}
