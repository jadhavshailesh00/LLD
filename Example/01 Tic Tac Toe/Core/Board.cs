namespace LLD.Example._01_Tic_Tac_Toe
{
    public class Board
    {
        private readonly int rows;
        private readonly int columns;
        private Symbol[,] grid;
        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            grid = new Symbol[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    grid[i, j] = Symbol.None;
                }
            }
        }

        public bool IsValidMove(Position pos) =>
            pos.Row >= 0 && pos.Row < rows &&
                pos.Columns >= 0 && pos.Columns < columns &&
                grid[pos.Row, pos.Columns] == Symbol.None;

        public void MakeMove(Position position, Symbol symbol)
        {
            grid[position.Row, position.Columns] = symbol;
        }

        public bool CheckWin(Symbol symbol)
        {
            // Check rows
            for (int i = 0; i < rows; i++)
            {
                if (Enumerable.Range(0, columns).All(j => grid[i, j] == symbol))
                    return true;
            }

            // Check columns
            for (int j = 0; j < columns; j++)
            {
                if (Enumerable.Range(0, rows).All(i => grid[i, j] == symbol))
                    return true;
            }

            // Check diagonals
            if (Enumerable.Range(0, rows).All(i => grid[i, i] == symbol) ||
                Enumerable.Range(0, rows).All(i => grid[i, columns - 1 - i] == symbol))
                return true;

            return false;

        }

        public bool IsFull()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (grid[i, j] == Symbol.None)
                        return false;
                }
            }
            return true;
        }

        public void PrintBoard()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(grid[i, j] switch
                    {

                        Symbol.X => " X ",
                        Symbol.O => " O ",
                        _ => "   "
                    });
                    if (j < columns - 1)
                        Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < rows - 1)
                    Console.WriteLine("---+---+---");

            }
            Console.WriteLine();
        }
    }
}
