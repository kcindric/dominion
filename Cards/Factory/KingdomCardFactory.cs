using Dominion.Cards.KingdomCards;

namespace Dominion.Cards.Factory
{
    public abstract class KingdomCardFactory
    {
        public abstract IKingdomCard CreateKingdomCard();
    }

    public class ArtisanFactory : KingdomCardFactory
    {
        public override IKingdomCard CreateKingdomCard()
        {
            return new ArtisanCard(CardName.ARTISAN, 6, CardType.ACTION, "Gain a card to your hand costing up to 5.\nPut a card from your hand onto your deck.");
        }
    }

    public class GardensFactory : KingdomCardFactory
    {
        public override IKingdomCard CreateKingdomCard()
        {
            return new GardensCard(CardName.GARDENS, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", 1);
        }
    }
}
