using Tic_Tac_Toe.Players;

namespace Tic_Tac_Toe.States
{
    public class XWonState : IGameState
    {
        public void Next(GameContext context, Player player, bool hasWon) { }
        public bool IsGameOver() => true;
    }
}
