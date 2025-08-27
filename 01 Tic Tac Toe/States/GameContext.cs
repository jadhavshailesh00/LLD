using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Players;

namespace Tic_Tac_Toe.States
{
    public class GameContext
    {
        private IGameState currentState;

        public GameContext()
        {

        }

        public void SetState(IGameState currentState)
        {
            this.currentState = currentState;
        }

        public void Next(Player player, bool haswon)
        {
            currentState.Next(this, player, haswon);
        }

        public bool IsGameOver() => currentState.IsGameOver();

        public IGameState GateState() => currentState;
    }
}
