using Dominion.Cards.Victory;


namespace Dominion.Cards.KingdomCards
{
    class GardensCard : IKingdomCard, IVictoryCard
    {
        public string CardText { get; }
        public CardName Name { get; }
        public int Cost { get; }
        public CardType CardType { get; }
        public Player Player { get; set; }

        public int Points { get; }

        public GardensCard(CardName name, int cost, CardType cardType, string cardText, int points)
        {
            this.Name = name;
            this.Cost = cost;
            this.CardType = cardType;
            this.CardText = cardText;

            this.Points = points;
        }

        public void Play()
        {
        }

        public int EvaluateScore()
        {
            return this.Player.Deck.DeckSize / 10 * this.Points;
        }
    }
}
