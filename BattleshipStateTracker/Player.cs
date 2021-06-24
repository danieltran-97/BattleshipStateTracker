using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using BattleshipStateTracker.Ships;

namespace BattleshipStateTracker
{
    public class Player
    {
        public string Name { get; set; }
        public Board ShipsBoard = new Board();
        public Board FiringBoard = new Board();
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
            FiringBoard.PrintBoard();
            
            Console.WriteLine("Ships board:");
            ShipsBoard.PrintBoard();
            
        }

        public void PlaceShips(Ship ship)
        {
            var random = new Random();
            
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

                var affectedSlots = Board.Slots.Range(rowStart, columnStart, rowEnd, columnEnd);
                if (affectedSlots.Any(x => x.Occupied))
                {
                    open = true;
                    continue;
                }
                foreach (var slot in affectedSlots)
                {
                    slot.SlotStatus = ship.SlotStatus;
                }
                open = false;
            }

        }
    }
}