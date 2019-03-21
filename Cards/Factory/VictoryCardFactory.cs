using Dominion.Cards.Victory;
using Dominion.Cards.VictoryCards;

namespace Dominion.Cards.Factory
{
    public abstract class VictoryCardFactory
    {
        public abstract IVictoryCard CreateVictoryCard();
    }

    public class EstateCardFactory : VictoryCardFactory
    {
        public override IVictoryCard CreateVictoryCard()
        {
            return new EstateCard(CardName.ESTATE, 2, CardType.VICTORY, 1);
        }
    }

    public class DuchyCardFactory : VictoryCardFactory
    {
        public override IVictoryCard CreateVictoryCard()
        {
            return new DuchyCard(CardName.DUCHY, 5, CardType.VICTORY, 3);
        }
    }

    public class ProvinceCardFactory : VictoryCardFactory
    {
        public override IVictoryCard CreateVictoryCard()
        {
            return new ProvinceCard(CardName.PROVINCE, 8, CardType.VICTORY, 6);
        }
    }

    public class CurseCardFactory : VictoryCardFactory
    {
        public override IVictoryCard CreateVictoryCard()
        {
            return new CurseCard(CardName.CURSE, 0, CardType.VICTORY, -1);
        }
    }
}
