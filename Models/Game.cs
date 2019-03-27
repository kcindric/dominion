using System.Collections.Generic;
using System;
using Dominion.Models.Cards.Interfaces;
using Dominion.Models.Cards.Factory;

namespace Dominion.Models
{
    public enum TurnPhase
    {
        ACTION,
        BUY,
        CLEANUP,
        GAME_END
    }

    public class Game
    {
        public int NumberOfPlayers
        {
            get { return Players.Count; }
        }

        public int RemainingProvinces;

        public List<Player> Players;
        public Player StartingPlayer;
        public Player PlayerOnTurn;
        public int TurnNumber;
        public List<Stack<ICard>> CardsInPlay;
        public TurnPhase TurnPhase;
        public int EmptyStacks;

        public Game(List<Player> players)
        {
            this.Players = players;
            this.Setup();
        }

        private void Setup()
        {
            this.TurnNumber = 1;
            Random rand = new Random();
            this.PlayerOnTurn = this.StartingPlayer = Players[rand.Next(0, Players.Count - 1)];
            this.TurnPhase = TurnPhase.ACTION;
            RemainingProvinces = this.NumberOfPlayers == 2 ? 8 : 12;
            CardsInPlay = new List<Stack<ICard>>();
            SetupCardSets();
        }

        private void SetupCardSets()
        {
            Stack<ICard> copper = new Stack<ICard>();
            for (int i = 0; i < 60 - (NumberOfPlayers * 7); i++)
                copper.Push(BigFuckingFactory.TreasureCardFactories[CardName.COPPER].CreateTreasureCard());

            Stack<ICard> silver = new Stack<ICard>();
            for (int i = 0; i < 40; i++)
                silver.Push(BigFuckingFactory.TreasureCardFactories[CardName.SILVER].CreateTreasureCard());

            Stack<ICard> gold = new Stack<ICard>();
            for (int i = 0; i < 30; i++)
                gold.Push(BigFuckingFactory.TreasureCardFactories[CardName.GOLD].CreateTreasureCard());


            Stack<ICard> estate = new Stack<ICard>();
            for (int i = 0; i < RemainingProvinces; i++)
                estate.Push(BigFuckingFactory.VictoryCardFactories[CardName.ESTATE].CreateVictoryCard());

            Stack<ICard> duchy = new Stack<ICard>();
            for (int i = 0; i < RemainingProvinces; i++)
                duchy.Push(BigFuckingFactory.VictoryCardFactories[CardName.DUCHY].CreateVictoryCard());

            Stack<ICard> province = new Stack<ICard>();
            for (int i = 0; i < RemainingProvinces; i++)
                province.Push(BigFuckingFactory.VictoryCardFactories[CardName.PROVINCE].CreateVictoryCard());

            Stack<ICard> curse = new Stack<ICard>();
            for (int i = 0; i < 40; i++)
                curse.Push(BigFuckingFactory.VictoryCardFactories[CardName.CURSE].CreateVictoryCard());

            Random rand = new Random();

            List<int> kc = new List<int>((int[])Enum.GetValues(typeof(CardName)));
            kc.RemoveRange(0, 7); //remove treasure and victory cards

            for (int i = 0; i < 10; i++)
            {
                Stack<ICard> kingdom = new Stack<ICard>();
                int r = rand.Next(0, kc.Count - 1);

                for(int j=0;j<10;j++)
                {
                    kingdom.Push(BigFuckingFactory.KingdomCardFactories[(CardName)kc[r]].CreateKingdomCard());
                }

                CardsInPlay.Add(kingdom);
                kc.RemoveAt(r);
            }

            CardsInPlay.Add(copper);
            CardsInPlay.Add(silver);
            CardsInPlay.Add(gold);

            CardsInPlay.Add(curse);
            CardsInPlay.Add(estate);
            CardsInPlay.Add(duchy);
            CardsInPlay.Add(province);
        }

        public void Advance()
        {
            if (this.TurnPhase != TurnPhase.CLEANUP)
            {
                this.TurnPhase++;
                return;
            }

            //on cleanup
            this.PlayerOnTurn = Players[(Players.IndexOf(this.PlayerOnTurn) + 1) % Players.Count];
            if (this.StartingPlayer == this.PlayerOnTurn)
                TurnNumber++;

            //check game end triggers
            if (EmptyStacks == 3 || RemainingProvinces == 0)
                this.TurnPhase = TurnPhase.GAME_END;
            else
                this.TurnPhase = TurnPhase.ACTION;
        }

        public Dictionary<Player, int> End()
        {
            Dictionary<Player, int> finalScoring = new Dictionary<Player, int>();

            foreach (Player p in Players)
            {
                finalScoring.Add(p, p.CountPoints());    
            }

            return finalScoring;
        }
    }
}
