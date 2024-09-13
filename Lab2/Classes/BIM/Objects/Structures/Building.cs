using Lab2.Classes.BIM.Objects.Base;

namespace Lab2.Classes.BIM.Objects.Structures;
internal class Building : Structure
{
    private uint _floors;
    public uint Floors
    {
        get => _floors;
        private set
        {
            if (value != _floors && value > 0)
            {
                _floors = value;
            }
        }
    }

    public Building(uint floors) : base()
    {
        _floors = floors;
    }

    public Building SetFloors(uint floors)
    {
        _floors = floors;
        return this;
    }
}
