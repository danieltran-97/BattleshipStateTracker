using System.Collections.Generic;
using System.Linq;

namespace BattleshipStateTracker
{
    public static class SlotExtensions
    {   
        public static Slot At(this List<Slot> slots, int row, int column)
        {
            return slots.First(x => x.Coordinate.Row == row && x.Coordinate.Column == column);
        }
        public static List<Slot> Range(this List<Slot> slots, int rowStart, int columnStart, int rowEnd, int columnEnd)
        {
            return slots.Where(s => s.Coordinate.Row >= rowStart
                               && s.Coordinate.Column >= columnStart
                               && s.Coordinate.Row <= rowEnd
                               && s.Coordinate.Column <= columnEnd).ToList();
        }
    }
}