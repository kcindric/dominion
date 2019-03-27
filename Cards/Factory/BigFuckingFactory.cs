using System.Collections.Generic;

namespace Dominion.Cards.Factory
{
    public static class BigFuckingFactory
    {
        public static Dictionary<CardName, KingdomCardFactory> KingdomCardFactories;
        public static Dictionary<CardName, VictoryCardFactory> VictoryCardFactories;
        public static Dictionary<CardName, TreasureCardFactory> TreasureCardFactories;

        static BigFuckingFactory()
        {
            KingdomCardFactories = new Dictionary<CardName, KingdomCardFactory>();
            VictoryCardFactories = new Dictionary<CardName, VictoryCardFactory>();
            TreasureCardFactories = new Dictionary<CardName, TreasureCardFactory>();

            KingdomCardFactories.Add(CardName.ARTISAN, new ArtisanFactory());
            KingdomCardFactories.Add(CardName.GARDENS, new GardensFactory());

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
