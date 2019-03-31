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

        private readonly CardEffect _cardEffects;

        public KingdomCard(CardName name, int cost, CardType cardType, string cardText, CardEffect cardEffects)
        {
            Name = name;
            Cost = cost;
            CardType = cardType;
            CardText = cardText;
            _cardEffects = cardEffects;
        }

        public void Play(Game game, IPlayerView playerView)
        {
            if(Player == null)
                throw new Exception("Owner of this card is not set. Cannot play");

            _cardEffects.Invoke(game, Player, playerView);
        }
    }
}
