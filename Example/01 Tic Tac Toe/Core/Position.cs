namespace LLD.Example._01_Tic_Tac_Toe
{
    public class Position
    {
        public int Row;

        public int Columns;
        public Position(int row, int columns)
        {
            Row = row;
            Columns = columns;
        }

        public override string ToString()
        {
            return $"({Row}, {Columns})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Position other)
                return Row == other.Row && Columns == other.Columns;
            return false;
        }

        public override int GetHashCode()
        {
            return Row * 31 + Columns;
        }
    }
}
