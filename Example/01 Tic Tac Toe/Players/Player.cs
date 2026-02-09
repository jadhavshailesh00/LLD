using Tic_Tac_Toe.Core;

namespace Tic_Tac_Toe.Players
{
    public class Player
    {
        public Symbol Symbol { get; }

        public IPlayerStrategy Strategy { get; }

        public Player(Symbol symbol, IPlayerStrategy strategy)
        {
            Symbol = symbol;
            Strategy = strategy;
        }
    }
}
