using System.Collections.Generic;
using Dominion.Models;

namespace Dominion.Views
{
    public interface IGameView
    {
        void ShowFinalScoring(Dictionary<Player, int> finalScoring);
        void ChangeTurnPhase(TurnPhase turnPhase);
        void ChangePlayerOnTurn(Player playerOnTurn);
    }
}
