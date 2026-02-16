namespace LLD.Example._01_Tic_Tac_Toe
{
    public class Tic_Tac_Toe
    {
        public void Run()
        {
            var playerXStrategy = new HumanPlayerStrategy("Player X");
            var playerOStrategy = new HumanPlayerStrategy("Player O");

            var game = new TicTacToeGame(playerXStrategy, playerOStrategy);
            game.Play();
        }
    }

}

