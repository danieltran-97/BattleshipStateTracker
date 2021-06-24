using System;
using System.Collections.Generic;

namespace BattleshipStateTracker
{
    public class Board
    {
        public static List<Slot> Slots { get; set; }
        public  Board()
        {
            Slots = new List<Slot>();
            
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    Slots.Add(new Slot(i,j));
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
            
            for (var i = 0; i < 10; i++)
            {
                Console.Write("{0} |", rowLetter[i]);
                for (var j = 0; j < 10; j++)
                {
                    Console.Write("{0} ", Slots.At(i, j).Status);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}