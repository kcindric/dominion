using Dominion.Models.Cards.Interfaces;


namespace Dominion.Models.Cards.KingdomCards
{
    public class GardensCard : IKingdomCard, IVictoryCard
    {
        public string CardText { get; }
        public CardName Name { get; }
        public int Cost { get; }
        public CardType CardType { get; }
        public Player Player { get; set; }

        private readonly int _points;

        public int Points => Player.DiscardPile.Size / 10 * _points;

        public GardensCard(CardName name, int cost, CardType cardType, string cardText, int points)
        {
            this.Name = name;
            this.Cost = cost;
            this.CardType = cardType;
            this.CardText = cardText;
            this._points = points;
        }

        public void Play()
        {
        }
    }
}
