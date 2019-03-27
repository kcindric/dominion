using Dominion.Models.Cards.Interfaces;
using Dominion.Models.Cards.VictoryCards;

namespace Dominion.Models.Cards.Factory
{
    internal abstract class VictoryCardFactory
    {
        internal abstract IVictoryCard CreateVictoryCard();
    }

    internal class EstateCardFactory : VictoryCardFactory
    {
        internal override IVictoryCard CreateVictoryCard()
        {
            return new EstateCard(CardName.ESTATE, 2, CardType.VICTORY, 1);
        }
    }

    internal class DuchyCardFactory : VictoryCardFactory
    {
        internal override IVictoryCard CreateVictoryCard()
        {
            return new DuchyCard(CardName.DUCHY, 5, CardType.VICTORY, 3);
        }
    }

    internal class ProvinceCardFactory : VictoryCardFactory
    {
        internal override IVictoryCard CreateVictoryCard()
        {
            return new ProvinceCard(CardName.PROVINCE, 8, CardType.VICTORY, 6);
        }
    }

    internal class CurseCardFactory : VictoryCardFactory
    {
        internal override IVictoryCard CreateVictoryCard()
        {
            return new CurseCard(CardName.CURSE, 0, CardType.VICTORY, -1);
        }
    }
}
