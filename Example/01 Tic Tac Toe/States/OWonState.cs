namespace LLD.Example._01_Tic_Tac_Toe
{
    public class OWonState : IGameState
    {
        public void Next(GameContext context, Player player, bool hasWon) { }
        public bool IsGameOver() => true;
    }
}
