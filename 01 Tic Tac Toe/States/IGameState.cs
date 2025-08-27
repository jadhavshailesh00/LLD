using Tic_Tac_Toe.Players;

namespace Tic_Tac_Toe.States
{
    public interface IGameState
    {
        public void Next(GameContext context, Player player, bool haswon);

        public bool IsGameOver();
    }
}
