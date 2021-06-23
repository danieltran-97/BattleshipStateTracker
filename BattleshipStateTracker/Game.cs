namespace BattleshipStateTracker
{
    public class Game
    {
        public Player Player1 = new Player("Player 1");
        public Player Player2 = new Player("Player 2");

        public void NewGame()
        {
            Player1.ShipsBoard.InitializeBoard();
            Player1.FiringBoard.InitializeBoard();
            Player2.ShipsBoard.InitializeBoard();
            Player2.FiringBoard.InitializeBoard();
        }

    }
}