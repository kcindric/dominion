
using Dominion.Models;
using Dominion.Views;
using System.Collections.Generic;

namespace Dominion.Controllers
{
    public class GameController
    {
        private readonly Game _game;
        private readonly IGameView _gameView;
        private readonly Dictionary<Player, PlayerController> _playerControllers;

        public GameController(Game gameModel, IGameView gameView, Dictionary<Player,PlayerController> playerControllers)
        {
            _game = gameModel;
            _gameView = gameView;
            _playerControllers = playerControllers;
        }

        public void StartGame()
        {
            while (_game.TurnPhase != TurnPhase.GAME_END)
            {
                _gameView.ChangeTurnPhase(_game.TurnPhase);

                switch (_game.TurnPhase)
                {
                    case TurnPhase.ACTION:
                        _gameView.ChangePlayerOnTurn(_game.PlayerOnTurn);
                        _playerControllers[_game.PlayerOnTurn].StartActionPhase();
                        break;
                    case TurnPhase.BUY:
                        _playerControllers[_game.PlayerOnTurn].StartBuyPhase(_game.CardsInPlay);
                        break;
                    case TurnPhase.CLEANUP:
                        _playerControllers[_game.PlayerOnTurn].StartCleanupPhase();
                        break;
                }

                _game.Advance();
            }

            var finalScoring = _game.End();
            _gameView.ShowFinalScoring(finalScoring);
        }
    }
}
