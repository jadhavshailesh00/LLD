namespace LLD.Example._01_Tic_Tac_Toe
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
