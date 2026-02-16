namespace LLD.Example._01_Tic_Tac_Toe
{
    public class OTurnState : IGameState
    {
        public void Next(GameContext context, Player player, bool hasWon)
        {
            if (hasWon)
                context.SetState(player.Symbol == Symbol.X ? new XWonState() : new OWonState());
            else
                context.SetState(new XTurnState());
        }

        public bool IsGameOver() => false;
    }
}
