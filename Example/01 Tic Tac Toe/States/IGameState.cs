namespace LLD.Example._01_Tic_Tac_Toe
{
    public interface IGameState
    {
        public void Next(GameContext context, Player player, bool haswon);

        public bool IsGameOver();
    }
}
