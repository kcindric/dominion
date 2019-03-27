using System.Collections.Generic;
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Models.Cards.Factory
{
    public static class BigFuckingFactory
    {
        internal static Dictionary<CardName, KingdomCardFactory> KingdomCardFactories;
        internal static Dictionary<CardName, VictoryCardFactory> VictoryCardFactories;
        internal static Dictionary<CardName, TreasureCardFactory> TreasureCardFactories;

        static BigFuckingFactory()
        {
            KingdomCardFactories = new Dictionary<CardName, KingdomCardFactory>();
            VictoryCardFactories = new Dictionary<CardName, VictoryCardFactory>();
            TreasureCardFactories = new Dictionary<CardName, TreasureCardFactory>();

            KingdomCardFactories.Add(CardName.ARTISAN, new ArtisanFactory());
            KingdomCardFactories.Add(CardName.BANDIT, new BanditFactory());
            KingdomCardFactories.Add(CardName.BUREAUCRAT, new BureaucratFactory());
            KingdomCardFactories.Add(CardName.CELLAR, new CellarFactory());
            KingdomCardFactories.Add(CardName.CHAPEL, new ChapelFactory());
            KingdomCardFactories.Add(CardName.COUNCIL_ROOM, new CouncilRoomFactory());
            KingdomCardFactories.Add(CardName.FESTIVAL, new FestivalFactory());
            KingdomCardFactories.Add(CardName.GARDENS, new GardensFactory());
            KingdomCardFactories.Add(CardName.HARBINGER, new HarbingerFactory());
            KingdomCardFactories.Add(CardName.LABORATORY, new LaboratoryFactory());
            KingdomCardFactories.Add(CardName.LIBRARY, new LibraryFactory());
            KingdomCardFactories.Add(CardName.MARKET, new MarketFactory());
            KingdomCardFactories.Add(CardName.MERCHANT, new MerchantFactory());
            KingdomCardFactories.Add(CardName.MILITIA, new MilitiaFactory());
            KingdomCardFactories.Add(CardName.MINE, new MineFactory());
            KingdomCardFactories.Add(CardName.MOAT, new MoatFactory());
            KingdomCardFactories.Add(CardName.MONEYLENDER, new MoneylenderFactory());
            KingdomCardFactories.Add(CardName.POACHER, new PoacherFactory());
            KingdomCardFactories.Add(CardName.REMODEL, new RemodelFactory());
            KingdomCardFactories.Add(CardName.SENTRY, new SentryFactory());
            KingdomCardFactories.Add(CardName.SMITHY, new SmithyFactory());
            KingdomCardFactories.Add(CardName.THRONE_ROOM, new ThroneRoomFactory());
            KingdomCardFactories.Add(CardName.VASSAL, new VassalFactory());
            KingdomCardFactories.Add(CardName.VILLAGE, new VillageFactory());
            KingdomCardFactories.Add(CardName.WITCH, new WitchFactory());
            KingdomCardFactories.Add(CardName.WORKSHOP, new WorkshopFactory());


            VictoryCardFactories.Add(CardName.ESTATE, new EstateCardFactory());
            VictoryCardFactories.Add(CardName.DUCHY, new DuchyCardFactory());
            VictoryCardFactories.Add(CardName.PROVINCE, new ProvinceCardFactory());
            VictoryCardFactories.Add(CardName.CURSE, new CurseCardFactory());

            TreasureCardFactories.Add(CardName.COPPER, new CopperCardFactory());
            TreasureCardFactories.Add(CardName.SILVER, new SilverCardFactory());
            TreasureCardFactories.Add(CardName.GOLD, new GoldCardFactory());
        }

    }
}
