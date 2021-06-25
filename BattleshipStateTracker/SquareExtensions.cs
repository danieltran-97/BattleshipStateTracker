using System.Collections.Generic;
using System.Linq;

namespace BattleshipStateTracker
{
    public static class SquareExtensions
    {   
        public static Square At(this List<Square> slots, int row, int column)
        {
            return slots.First(x => x.Coordinate.Row == row && x.Coordinate.Column == column);
        }
        public static List<Square> Range(this List<Square> slots, int rowStart, int columnStart, int rowEnd, int columnEnd)
        {
            return slots.Where(s => s.Coordinate.Row >= rowStart
                               && s.Coordinate.Column >= columnStart
                               && s.Coordinate.Row <= rowEnd
                               && s.Coordinate.Column <= columnEnd).ToList();
        }
    }
}