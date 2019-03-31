
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
            foreach (Player player in _game.Players)
                player.Setup();

            _gameView.StartGameRender();

            while (_game.TurnPhase != TurnPhase.GAME_END)
            {

                switch (_game.TurnPhase)
                {
                    case TurnPhase.ACTION:
                        _gameView.StartTurnRender(_game.PlayerOnTurn);
                        _gameView.TurnPhaseRender(_game.TurnPhase);
                        _playerControllers[_game.PlayerOnTurn].StartActionPhase();
                        break;
                    case TurnPhase.BUY:
                        _gameView.TurnPhaseRender(_game.TurnPhase);
                        _playerControllers[_game.PlayerOnTurn].StartBuyPhase(_game.CardsInPlay);
                        break;
                    case TurnPhase.CLEANUP:
                        _gameView.TurnPhaseRender(_game.TurnPhase);
                        _playerControllers[_game.PlayerOnTurn].StartCleanupPhase();
                        break;
                }

                _game.Advance();
            }

            Dictionary<Player, int> finalScoring = _game.End();
            _gameView.ShowFinalScoring(finalScoring);
        }
    }
}
