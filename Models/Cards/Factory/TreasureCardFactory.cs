using Dominion.Models.Cards.Interfaces;
using Dominion.Models.Cards.TreasureCards;

namespace Dominion.Models.Cards.Factory
{
    internal abstract class TreasureCardFactory
    {
        public abstract ITreasureCard CreateTreasureCard();
    }

    internal class CopperCardFactory : TreasureCardFactory
    {
        public override ITreasureCard CreateTreasureCard()
        {
            return new CopperCard(CardName.COPPER, 0, CardType.TREASURE, 1);
        }
    }

    internal class SilverCardFactory : TreasureCardFactory
    {
        public override ITreasureCard CreateTreasureCard()
        {
            return new SilverCard(CardName.SILVER, 3, CardType.VICTORY, 2);
        }
    }

    internal class GoldCardFactory : TreasureCardFactory
    {
        public override ITreasureCard CreateTreasureCard()
        {
            return new GoldCard(CardName.GOLD, 6, CardType.VICTORY, 3);
        }
    }
}
