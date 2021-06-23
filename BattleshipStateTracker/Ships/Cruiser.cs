namespace BattleshipStateTracker.Ships
{
    public class Cruiser : Ship
    {
        public Cruiser()
        {
            Name = "Cruiser";
            Width = 3;
            CoordinateStatus = CoordinateStatus.Cruiser;
        }
    }
}