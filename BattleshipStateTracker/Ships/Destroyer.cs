namespace BattleshipStateTracker.Ships
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Name = "Destroyer";
            Width = 2;
            CoordinateStatus = CoordinateStatus.Destroyer;
        }
    }
}