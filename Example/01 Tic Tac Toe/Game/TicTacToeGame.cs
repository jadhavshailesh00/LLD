namespace LLD.Example._01_Tic_Tac_Toe
{
    public class TicTacToeGame
    {
        private readonly Board board;
        private readonly Player playerx;
        private readonly Player playero;
        private Player currentPlayer;
        private readonly GameContext context;

        public TicTacToeGame(IPlayerStrategy playerXStrategy, IPlayerStrategy playerOStrategy, int size = 3)
        {
            board = new Board(size, size);
            playerx = new Player(Symbol.X, playerXStrategy);
            playero = new Player(Symbol.O, playerOStrategy);
            currentPlayer = playerx;
            context = new GameContext();

        }

        public void Play()
        {
            do
            {
                board.PrintBoard();
                Position move = currentPlayer.Strategy.MakeMove(board);
                context.SetState(new OTurnState());
                board.MakeMove(move, currentPlayer.Symbol);
                bool hasWon = board.CheckWin(currentPlayer.Symbol);
                if (hasWon || board.IsFull())
                {
                    context.SetState(hasWon ?
                        currentPlayer.Symbol == Symbol.X ? new XWonState() : new OWonState() : new DrawState());
                }
                else
                {
                    context.Next(currentPlayer, false);

                }
                SwitchPlayer();

            } while (!context.IsGameOver());
            AnnounceResult();
        }

        private void SwitchPlayer()
        {
            currentPlayer = currentPlayer == playerx ? playero : playerx;
        }

        private void AnnounceResult()
        {
            var state = context.GateState();
            if (state is XWonState) Console.WriteLine("Player X wins!");
            else if (state is OWonState) Console.WriteLine("Player O wins!");
            else Console.WriteLine("It's a draw!");
        }
    }
}
