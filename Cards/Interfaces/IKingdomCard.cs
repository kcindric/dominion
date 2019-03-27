
namespace Dominion.Cards
{
    public interface IKingdomCard : ICard
    {
        string CardText { get; }

        void Play();
    }
}
