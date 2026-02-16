namespace LLD.Example._01_Tic_Tac_Toe
{
    internal class HumanPlayerStrategy : IPlayerStrategy
    {
        private readonly string PlayerName;

        public HumanPlayerStrategy(string playerName)
        {
            PlayerName = playerName;
        }

        public Position MakeMove(Board board)
        {
            while (true)
            {
                Console.WriteLine($"{PlayerName}, enter your move (row and column separated by space): ");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                var parts = input.Split(' ');
                if (parts.Length != 2) continue;

                if (int.TryParse(parts[0], out int row) && int.TryParse(parts[1], out int column))
                {
                    var pos = new Position(row, column);

                    if (board.IsValidMove(pos))
                    {
                        return pos;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move. Please try again.");
                    }
                }

                Console.WriteLine("Invalid input. Please enter two numbers separated by a space.");
            }
        }
    }
}
