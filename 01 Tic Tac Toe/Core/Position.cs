using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Core
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
