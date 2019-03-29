using System.Collections.Generic;
using Dominion.Models;

namespace Dominion.Views
{
    public interface IGameView
    {
        void ShowFinalScoring(Dictionary<Player, int> finalScoring);
        void TurnPhaseRender(TurnPhase turnPhase);
        void StartTurnRender(Player playerOnTurn);
        void StartGameRender();
    }
}
