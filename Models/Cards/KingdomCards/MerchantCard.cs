﻿
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Models.Cards.KingdomCards
{
    public class MerchantCard : IKingdomCard
    {
        public string CardText { get; }
        public CardName Name { get; }
        public int Cost { get; }
        public CardType CardType { get; }
        public Player Player { get; set; }

        public MerchantCard(CardName name, int cost, CardType cardType, string cardText)
        {
            this.Name = name;
            this.Cost = cost;
            this.CardType = cardType;
            this.CardText = cardText;
        }

        public void Play()
        {
        }


    }
}
