using Tic_Tac_Toe.Core;

namespace Tic_Tac_Toe.Players
{
    public interface IPlayerStrategy
    {
        public Position MakeMove(Board board);

    }
}
