using Dominion.Controllers;
using Dominion.Models.Cards.Interfaces;
using Dominion.Models.Cards.KingdomCards;

namespace Dominion.Models.Cards.Factory
{
    internal abstract class KingdomCardFactory
    {
        internal abstract IKingdomCard CreateKingdomCard();
    }


    internal class ArtisanFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
              + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.ARTISAN, 6, CardType.ACTION, "Gain a card to your hand costing up to 5.\nPut a card from your hand onto your deck.", cardEffect);
        }
    }


    //internal class ArtisanFactory : KingdomCardFactory
    //{
    //    internal override IKingdomCard CreateKingdomCard()
    //    {
    //        return new ArtisanCard(CardName.ARTISAN, 6, CardType.ACTION, "Gain a card to your hand costing up to 5.\nPut a card from your hand onto your deck.");
    //    }
    //}

    internal class BanditFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.BANDIT, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class BureaucratFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.BUREAUCRAT, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class CellarFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.CELLAR, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class ChapelFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.CHAPEL, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class CouncilRoomFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.COUNCIL_ROOM, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class FestivalFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.FESTIVAL, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class GardensFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.GARDENS, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class HarbingerFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.HARBINGER, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class LaboratoryFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.LABORATORY, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class LibraryFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.LIBRARY, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class MarketFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.MARKET, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class MerchantFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.MERCHANT, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class MilitiaFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.MILITIA, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class MineFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.MINE, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class MoatFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.MOAT, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class MoneylenderFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.MONEYLENDER, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class PoacherFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.POACHER, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class RemodelFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.REMODEL, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class SentryFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.SENTRY, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class SmithyFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.SMITHY, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class ThroneRoomFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.THRONE_ROOM, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class VassalFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.VASSAL, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class VillageFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.VILLAGE, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class WitchFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.WITCH, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }

    internal class WorkshopFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            CardEffect cardEffect =
                new CardEffect(CardEffectController.PutCardFromHandOntoDeck)
                + new CardEffect(CardEffectController.GainCardWorthUpTo5);

            return new KingdomCard(CardName.WORKSHOP, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", cardEffect);
        }
    }
}
