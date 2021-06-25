using System.ComponentModel;

namespace BattleshipStateTracker
{
    public enum StatusType
    {
        Empty = '□',
        Battleship = 'B',
        Carrier = 'A',
        Cruiser = 'C',
        Destroyer = 'D',
        Submarine = 'S',
        Hit = 'X',
        Miss = 'M'
    }

    public enum ShotOutcome
    {
        Hit,
        Miss
    }
}