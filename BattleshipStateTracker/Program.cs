using System;

namespace BattleshipStateTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            game.NewGame();
            game.Player1.DisplayBoards();
            game.Player2.DisplayBoards();
            
        }
    }
}