
using System.Collections.Generic;
using Dominion.Models.Cards.Interfaces;

namespace Dominion.Views
{
    public interface IPlayerView
    {
        /// <summary>
        /// Method for rendering visual representation of a start of player's turn (Action Phase).
        /// </summary>
        /// <param name="turnNumber">Player's current turn number in this game</param>
        /// <param name="actions">Number of remaining actions for this player</param>
        /// <param name="buys">Number of remaining buys for this player</param>
        /// <param name="money">Amount of money player is holding in his hand at the start of his or her turn</param>
        /// <param name="startingHand">Cards in hand at start of the turn</param>
        void StartTurnRender(int turnNumber, int actions, int buys, int money, IEnumerable<ICard> startingHand);
        
        /// <summary>
        /// Renders arbitrary message to the player
        /// </summary>
        /// <param name="message">Message string</param>
        void MessageRender(string message);

        /// <summary>
        /// Method for rendering visual representation of the CleanupRender Phase in player's turn.
        /// </summary>
        /// <param name="newHand">List of cards in Player's newly drawn hand from deck</param>
        /// <param name="actions">Number of player's actions after resetting for the next turn</param>
        /// <param name="buys">Number of player's buys after resetting for the next turn</param>
        /// <param name="money">Amount of money in player's hand after resetting for the next turn</param>
        void CleanupRender(IEnumerable<ICard> newHand, int actions, int buys, int money);

        /// <summary>
        /// Method for displaying interactive buy options to player.
        /// </summary>
        /// <param name="money">Amount of money in player's buying budget</param>
        /// <param name="cardsInPlay">List of available card stacks to buy from</param>
        /// <returns>Stack of cards player chose to buy one card from. Card will be popped from stack in the controller.</returns>
        Stack<ICard> PromptBuyRender(int money, List<Stack<ICard>> cardsInPlay);

        /// <summary>
        /// Method for displaying results of the player's Buy Phase and ending it.
        /// </summary>
        /// <param name="boughtCards">Collection of bought cards, for display purposes. Nullable</param>
        void EndBuyPhaseRender(IEnumerable<ICard> boughtCards);

        /// <summary>
        /// Method for animating card buying process.
        /// </summary>
        /// <param name="lastBoughtCard">Last bought card</param>
        /// <param name="money">Amount of remaining money in player's budget</param>
        void BuyCardRender(ICard lastBoughtCard, int money);
    }
}
