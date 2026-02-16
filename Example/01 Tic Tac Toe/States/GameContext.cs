namespace LLD.Example._01_Tic_Tac_Toe
{
    public class GameContext
    {
        private IGameState currentState;

        public GameContext()
        {

        }

        public void SetState(IGameState currentState)
        {
            this.currentState = currentState;
        }

        public void Next(Player player, bool haswon)
        {
            currentState.Next(this, player, haswon);
        }

        public bool IsGameOver() => currentState.IsGameOver();

        public IGameState GateState() => currentState;
    }
}
