
using System.Collections.Generic;
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Views
{
    public interface IPlayerView
    {
        void StartTurn(int turnNumber, int actions, int buys, int money);
        void Cleanup(IEnumerable<ICard> cards, int actions, int buys, int money);
        ICard PromptBuy(int money);
        void EndBuyPhase(string message);
        void SetMoney(int money);
    }
}
