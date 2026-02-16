namespace LLD.Example._01_Tic_Tac_Toe
{
    public class XTurnState : IGameState
    {
        public bool IsGameOver() => false;

        public void Next(GameContext context, Player player, bool haswon)
        {
            if (haswon)
            {
                IGameState d = player.Symbol == Symbol.X ? new XWonState() : new OWonState();
                context.SetState(player.Symbol == Symbol.X ? new XWonState() : new OWonState());

            }
            else
            {
                context.SetState(new OTurnState());
            }
        }
    }
}
