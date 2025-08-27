using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Players;

namespace Tic_Tac_Toe.States
{
    public class DrawState : IGameState
    {
        public void Next(GameContext context, Player player, bool hasWon) { }
        public bool IsGameOver() => true;
    }
}
