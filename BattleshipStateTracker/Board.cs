using System;
using System.Collections.Generic;

namespace BattleshipStateTracker
{
    public class Board
    {
        public char[,] BoardMatrix = new char[10,10];
        public static List<Slot> Slots { get; set; }
        public  Board()
        {
            Slots = new List<Slot>();
            
            for (var i = 0; i < BoardMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < BoardMatrix.GetLength(1); j++)
                {
                    BoardMatrix[i, j] = (char)SlotStatus.Empty;
                }
            }
        }

        public void PrintBoard()
        {
            var rowLetter = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'};
            var columnNumber = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};

            Console.Write("   ");
            
            foreach (var number in columnNumber)
            {
                Console.Write("{0} ", number);
            }
            
            Console.WriteLine("\n   ___________________");
            
            for (var i = 0; i < BoardMatrix.GetLength(0); i++)
            {
                Console.Write("{0} |", rowLetter[i]);
                for (var j = 0; j < BoardMatrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", BoardMatrix[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}