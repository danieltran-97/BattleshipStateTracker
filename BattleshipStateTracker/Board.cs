using System;

namespace BattleshipStateTracker
{
    public class Board
    {
        public char[,] BoardMatrix = new char[10,10];

        public void InitializeBoard()
        {
            BoardMatrix = new char[10, 10]
            {
                {'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o'},
                {'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o'},
                {'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o'},
                {'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o'},
                {'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o'},
                {'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o'},
                {'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o'},
                {'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o'},
                {'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o'},
                {'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o'}
            };
        }

        public void PrintBoard()
        {
            var rowLetter = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'};
            var columnNumber = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
            var rowLength = BoardMatrix.GetLength(0);
            var columnLength = BoardMatrix.GetLength(1);

            Console.Write("   ");
            
            foreach (var number in columnNumber)
            {
                Console.Write("{0} ", number);
            }
            
            Console.WriteLine("\n   ___________________");
            
            for (var i = 0; i < rowLength; i++)
            {
                Console.Write("{0} |", rowLetter[i]);
                for (var j = 0; j < columnLength; j++)
                {
                    Console.Write("{0} ", BoardMatrix[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}