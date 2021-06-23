namespace BattleshipStateTracker.Ships
{
    public class Carrier : Ship
    {
        public Carrier()
        {
            Name = "Carrier";
            Width = 5;
            CoordinateStatus = CoordinateStatus.Carrier;
        }
    }
}