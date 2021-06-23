using System.ComponentModel;

namespace BattleshipStateTracker
{
    public enum CoordinateStatus
    {
        [Description("o")]
        Empty,
        
        [Description("B")]
        Battleship,
        
        [Description("A")]
        Carrier,
        
        [Description("C")]
        Cruiser,

        [Description("D")]
        Destroyer,

        [Description("S")]
        Submarine,

        [Description("X")]
        Hit,

        [Description("M")]
        Miss
    }

    public enum ShotOutcome
    {
        Hit,
        Miss
    }
}