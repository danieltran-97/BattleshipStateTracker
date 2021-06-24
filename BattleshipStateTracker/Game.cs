using System.Security.Cryptography.X509Certificates;
using BattleshipStateTracker.Ships;

namespace BattleshipStateTracker
{
    public class Game
    {
        public Player Player1 = new Player("Player 1");
        public Player Player2 = new Player("Player 2");

        public void Play()
        {
            Player1.PlaceShips(new Destroyer());
            Player1.DisplayBoards();
        }

    }
}