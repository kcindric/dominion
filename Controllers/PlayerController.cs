
using System.Collections.Generic;
using System.Linq;
using Dominion.Models;
using Dominion.Models.Cards.Interfaces;
using Dominion.Views;

namespace Dominion.Controllers
{
    public class PlayerController
    {
        private readonly Game _game;
        private readonly Player _player;
        private readonly IPlayerView _playerView;

        public PlayerController(Game gameModel, Player model, IPlayerView view)
        {
            _player = model;
            _playerView = view;
            _game = gameModel;
        }

        public void StartActionPhase()
        {
            _player.StartTurn();
            _playerView.StartTurnRender(_player.TurnNumber, _player.Actions, _player.Buys, _player.Money, _player.Hand.Cards);

            while (_player.Actions > 0)
            {

                IKingdomCard card = _playerView.PlayCard(_player.Hand.KingdomCards);
                if (card == null)
                    break;

                IKingdomCard playedCard = _player.Hand.Cards.First(c => c == card) as IKingdomCard;
                _player.Action(playedCard);
                playedCard?.Play(_game,_playerView);
            } 
        }

        public void StartBuyPhase(List<Stack<ICard>> cardsInPlay)
        {
            if (_player.Money == 0)
            {
                _playerView.EndBuyPhaseRender(null);
                return;
            }

            while (_player.Money > 0 && _player.Buys > 0)
            {
                Stack<ICard> chosenCardStack = _playerView.PromptBuyRender(_player.Money, cardsInPlay);
                if (chosenCardStack == null)
                    break;

                if (chosenCardStack.Peek().Cost <= _player.Money)
                {
                    _player.Buy(chosenCardStack.Pop());
                    _playerView.BuyCardRender(_player.LastBoughtThisTurn, _player.Money);
                }
                else
                {
                    _playerView.MessageRender("Not enough money, please choose another card.");
                }
            }

            _playerView.EndBuyPhaseRender(_player.BoughThisTurn);
        }

        public void StartCleanupPhase()
        {
            _player.Cleanup();
            _playerView.CleanupRender(_player.Hand.Cards, _player.Actions, _player.Buys, _player.Money);
        }
    }
}
