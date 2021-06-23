namespace BattleshipStateTracker.Ships
{
    public class Battleship : Ship
    {
        public Battleship()
        {
            Name = "Battleship";
            Width = 4;
            CoordinateStatus = CoordinateStatus.Battleship;
        }
    }
}