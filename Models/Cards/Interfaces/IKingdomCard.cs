
namespace Dominion.Models.Cards.Interfaces
{
    public interface IKingdomCard : ICard
    {
        string CardText { get; }

        void Play();
    }
}
