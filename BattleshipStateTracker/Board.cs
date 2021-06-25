using System;
using System.Collections.Generic;

namespace BattleshipStateTracker
{
    public class Board
    {
        public static List<Square> ShipsBoardSlots { get; set; }
        public static List<Square> FiringBoardSlots { get; set; }
        public  Board()
        {
            ShipsBoardSlots = new List<Square>();
            FiringBoardSlots = new List<Square>();
            
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    ShipsBoardSlots.Add(new Square(i,j));
                    FiringBoardSlots.Add(new Square(i,j));
                }
            }
        }

        public void PrintBoard(List<Square> boardSlots)
        {
            var rowLetter = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'};
            var columnNumber = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};

            Console.Write("   ");
            
            foreach (var number in columnNumber)
            {
                Console.Write("{0} ", number);
            }
            
            Console.WriteLine("\n   ___________________");
            
            for (var i = 0; i < 10; i++)
            {
                Console.Write("{0} |", rowLetter[i]);
                for (var j = 0; j < 10; j++)
                {
                    Console.Write("{0} ", boardSlots.At(i, j).Status);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}