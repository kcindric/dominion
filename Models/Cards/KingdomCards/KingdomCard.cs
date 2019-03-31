using System;
using Dominion.Controllers;
using Dominion.Models.Cards.Interfaces;
using Dominion.Views;

namespace Dominion.Models.Cards.KingdomCards
{
    public class KingdomCard : IKingdomCard
    {
        public string CardText { get; }
        public CardName Name { get; }
        public int Cost { get; }
        public CardType CardType { get; }
        public Player Player { get; set; }

        private readonly CardEffect _cardEffect;

        public KingdomCard(CardName name, int cost, CardType cardType, string cardText, CardEffect cardEffect)
        {
            this.Name = name;
            this.Cost = cost;
            this.CardType = cardType;
            this.CardText = cardText;
            this._cardEffect = cardEffect;
        }

        public void Play(Game game, IPlayerView playerView)
        {
            if(Player == null)
                throw new Exception("Owner of this card is not set. Cannot play");

            _cardEffect.Invoke(game, this.Player, playerView);
        }
    }
}
