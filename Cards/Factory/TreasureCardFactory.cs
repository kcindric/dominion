using Dominion.Cards.Treasure;
using Dominion.Cards.TreasureCards;

namespace Dominion.Cards.Factory
{
    public abstract class TreasureCardFactory
    {
        public abstract ITreasureCard CreateTreasureCard();
    }

    public class CopperCardFactory : TreasureCardFactory
    {
        public override ITreasureCard CreateTreasureCard()
        {
            return new CopperCard(CardName.COPPER, 0, CardType.TREASURE, 1);
        }
    }

    public class SilverCardFactory : TreasureCardFactory
    {
        public override ITreasureCard CreateTreasureCard()
        {
            return new SilverCard(CardName.SILVER, 3, CardType.VICTORY, 2);
        }
    }

    public class GoldCardFactory : TreasureCardFactory
    {
        public override ITreasureCard CreateTreasureCard()
        {
            return new GoldCard(CardName.GOLD, 6, CardType.VICTORY, 3);
        }
    }
}
