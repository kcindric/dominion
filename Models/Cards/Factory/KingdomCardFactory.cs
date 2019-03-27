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
            return new ArtisanCard(CardName.ARTISAN, 6, CardType.ACTION, "Gain a card to your hand costing up to 5.\nPut a card from your hand onto your deck.");
        }
    }

    internal class BanditFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new BanditCard(CardName.BANDIT, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class BureaucratFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new BureaucratCard(CardName.BUREAUCRAT, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class CellarFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new CellarCard(CardName.CELLAR, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class ChapelFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new ChapelCard(CardName.CHAPEL, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class CouncilRoomFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new CouncilRoomCard(CardName.COUNCIL_ROOM, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class FestivalFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new FestivalCard(CardName.FESTIVAL, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class GardensFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new GardensCard(CardName.GARDENS, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).", 1);
        }
    }

    internal class HarbingerFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new HarbingerCard(CardName.HARBINGER, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class LaboratoryFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new LaboratoryCard(CardName.LABORATORY, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class LibraryFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new LibraryCard(CardName.LIBRARY, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class MarketFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new MarketCard(CardName.MARKET, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class MerchantFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new MerchantCard(CardName.MERCHANT, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class MilitiaFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new MilitiaCard(CardName.MILITIA, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class MineFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new MineCard(CardName.MINE, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class MoatFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new MoatCard(CardName.MOAT, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class MoneylenderFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new MoneylenderCard(CardName.MONEYLENDER, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class PoacherFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new PoacherCard(CardName.POACHER, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class RemodelFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new RemodelCard(CardName.REMODEL, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class SentryFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new SentryCard(CardName.SENTRY, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class SmithyFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new SmithyCard(CardName.SMITHY, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class ThroneRoomFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new ThroneRoomCard(CardName.THRONE_ROOM, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class VassalFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new VassalCard(CardName.VASSAL, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class VillageFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new VillageCard(CardName.VILLAGE, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class WitchFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new WitchCard(CardName.WITCH, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }

    internal class WorkshopFactory : KingdomCardFactory
    {
        internal override IKingdomCard CreateKingdomCard()
        {
            return new WorkshopCard(CardName.WORKSHOP, 4, CardType.VICTORY, "Worth 1 VP per 10 cards you have (round down).");
        }
    }
}
