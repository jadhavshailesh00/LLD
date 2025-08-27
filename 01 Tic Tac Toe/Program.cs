using Tic_Tac_Toe;
using Tic_Tac_Toe.Game;
using Tic_Tac_Toe.Players;

var playerXStrategy = new HumanPlayerStrategy("Player X");
var playerOStrategy = new HumanPlayerStrategy("Player O");

var game = new TicTacToeGame(playerXStrategy, playerOStrategy);
game.Play();