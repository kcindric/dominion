
namespace Dominion.Cards
{
    public enum CardType
    {
        VICTORY,
        TREASURE,
        CURSE,
        ACTION,
        ACTION_ATTACK
    }

    public enum CardName
    {
        COPPER,
        SILVER,
        GOLD,

        CURSE,

        ESTATE,
        DUCHY,
        PROVINCE,

        ARTISAN,
        BANDIT,
        BUREAUCRAT,
        CELLAR,
        CHAPEL,
        COUNCIL_ROOM,
        FESTIVAL,
        GARDENS,
        HARBINGER,
        LABORATORY,
        LIBRARY,
        MARKET,
        MERCHANT,
        MILITIA,
        MINE,
        MOAT,
        MONEYLENDER,
        POACHER,
        REMODEL,
        SENTRY,
        SMITHY,
        THRONE_ROOM,
        VASSAL,
        VILLAGE,
        WITCH,
        WORKSHOP
    }

    public interface ICard
    {
        CardName Name { get; }
        int Cost { get; }
        CardType CardType { get; }
        Player Player { get; set; }
    }
}
