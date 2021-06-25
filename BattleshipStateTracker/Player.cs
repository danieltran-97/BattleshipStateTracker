using System;
using System.Collections.Generic;
using System.Linq;
using BattleshipStateTracker.Ships;

namespace BattleshipStateTracker
{
    public class Player
    {
        private string Name { get; set; }
        private Board _board = new Board();
        public List<Ship> Ships;

        public Player(string name)
        {
            Name = name;
            Ships = new List<Ship>() 
            {
                new Battleship(),
                new Carrier(), 
                new Cruiser(),
                new Destroyer(),
                new Submarine()
            };
        }

        public void DisplayBoards()
        {
            Console.WriteLine($"[{Name}]");
            
            Console.WriteLine("Firing board:");
            _board.PrintBoard(Board.FiringBoardSlots);
            
            Console.WriteLine("Ships board:");
            _board.PrintBoard(Board.ShipsBoardSlots);
            
        }

        public void DeployShips(List<Ship> ships)
        {
            var random = new Random();
            foreach(var ship in ships)
            {
                bool open = true;

                while (open)
                {
                    var orientation = random.Next(2); // 0 = horizontal
                    var rowStart = random.Next(11);
                    var columnStart = random.Next(11);
                    int rowEnd = rowStart, columnEnd = columnStart;

                    if (orientation == 0)
                    {
                        for (var i = 1; i < ship.Width; i++)
                        {
                            rowEnd++;
                        }
                    }
                    else
                    {
                        for (var i = 1; i < ship.Width; i++)
                        {
                            columnEnd++;
                        }
                    }

                    if (rowEnd > 10 || columnEnd > 10)
                    {
                        open = true;
                        continue;
                    }

                    var affectedSlots = Board.ShipsBoardSlots.Range(rowStart, columnStart, rowEnd, columnEnd);
                    if (affectedSlots.Any(x => x.Occupied))
                    {
                        open = true;
                        continue;
                    }

                    foreach (var slot in affectedSlots)
                    {
                        slot.StatusType = ship.StatusType;
                    }

                    open = false;
                }
            }
        }
    }
}