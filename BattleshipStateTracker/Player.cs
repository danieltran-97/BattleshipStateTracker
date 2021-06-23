using System;

namespace BattleshipStateTracker
{
    public class Player
    {
        public string Name { get; set; }
        public Board ShipsBoard = new Board();
        public Board FiringBoard = new Board();

        public Player(string name)
        {
            Name = name;
        }

        public void DisplayBoards()
        {
            Console.WriteLine($"[{Name}]");
            
            Console.WriteLine("Firing board:");
            FiringBoard.PrintBoard();
            
            Console.WriteLine("Ships board:");
            ShipsBoard.PrintBoard();
            
        }

    }
}