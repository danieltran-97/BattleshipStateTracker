namespace BattleshipStateTracker.Ships
{
    public class Ship
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Hits { get; set; }
        public CoordinateStatus CoordinateStatus { get; set; }
        public bool Sunk => Hits >= Width;
    }
}