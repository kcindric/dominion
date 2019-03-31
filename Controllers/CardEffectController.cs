
using Dominion.Models;
using Dominion.Models.Cards.Interfaces;
using Dominion.Views;

namespace Dominion.Controllers
{
    public delegate void CardEffect(Game game, Player player, IPlayerView view);
    public static class CardEffectController
    {
        public static void PutCardFromHandOntoDeck(Game game, Player player, IPlayerView view)
        {
            var card = view.ChooseCardFromHandRender(player.Hand.Cards);
            if (card != null)
                player.Deck.PutOnto(player.Hand.Remove(card));
            

        }

        public static void GainCardWorthUpTo5(Game game, Player player, IPlayerView view)
        {
            var cardName = view.GainCardRender(5, game.CardsInPlay.FindAll(c=> c.Peek().Cost <= 5));
            if (!cardName.Equals(null))
            {
                player.Gain(game.TakeCard(cardName));
            }

        }
    }
}
