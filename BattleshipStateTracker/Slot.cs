namespace BattleshipStateTracker
{
    public class Slot
    {
        public SlotStatus SlotStatus { get; set; }
        public Coordinate Coordinate { get; }
        
        public bool Occupied =>
            SlotStatus is SlotStatus.Battleship or SlotStatus.Carrier or SlotStatus.Cruiser or SlotStatus.Destroyer or SlotStatus.Submarine;

        public bool RandomSlotAvailable =>
            (Coordinate.Row % 2 == 0 && Coordinate.Column % 2 == 0)
            || (Coordinate.Row % 2 == 1 && Coordinate.Column % 2 == 1);

        public char Status
        {
            get
            {
                return (char) SlotStatus;
            }
        }

        public Slot(int row, int column)
        {
            Coordinate = new Coordinate(row, column);
            SlotStatus = SlotStatus.Empty;
        }
    }
}