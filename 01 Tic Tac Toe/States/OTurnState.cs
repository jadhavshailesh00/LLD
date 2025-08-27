using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Core;
using Tic_Tac_Toe.Players;

namespace Tic_Tac_Toe.States
{
    public class OTurnState : IGameState
    {
        public void Next(GameContext context, Player player, bool hasWon)
        {
            if (hasWon)
                context.SetState(player.Symbol == Symbol.X ? new XWonState() : new OWonState());
            else
                context.SetState(new XTurnState());
        }

        public bool IsGameOver() => false;
    }
}
