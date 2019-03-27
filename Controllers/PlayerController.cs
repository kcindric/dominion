
using System.Collections.Generic;
using Dominion.Models;
using Dominion.Models.Cards.Interfaces;
using Dominion.Views;

namespace Dominion.Controllers
{
    public class PlayerController
    {
        private readonly Player _player;
        private readonly IPlayerView _playerView;

        public PlayerController(Player model, IPlayerView view)
        {
            _player = model;
            _playerView = view;
        }

        public void StartActionPhase()
        {
            _player.StartTurn();
            _playerView.StartTurn(_player.TurnNumber, _player.Actions, _player.Buys, _player.Money);
        }

        public void StartBuyPhase(List<Stack<ICard>> cardsInPlay)
        {
            if (_player.Money == 0)
            {
                _playerView.EndBuyPhase("No money");
                return;
            }

            ICard boughtCard = _playerView.PromptBuy(_player.Money);

            while (_player.Money > 0 && _player.Buys > 0 && boughtCard != null)
            {
                _player.Buy(boughtCard);
                _playerView.SetMoney(_player.Money);
                boughtCard = _playerView.PromptBuy(_player.Money);
            }
        }

        public void StartCleanupPhase()
        {
            _player.Cleanup();
            _playerView.Cleanup(_player.Hand.Cards, _player.Actions, _player.Buys, _player.Money);
        }
    }
}
