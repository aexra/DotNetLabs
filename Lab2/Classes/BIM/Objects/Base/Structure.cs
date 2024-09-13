using Lab2.Classes.BIM.Base;

namespace Lab2.Classes.BIM.Objects.Base;
internal abstract class Structure : BIMObject
{
    public List<Room> Rooms { get; private set; }

    public Structure() : base()
    {

    }

    public Structure Configure(Action<Structure> structureBuilder)
    {
        structureBuilder(this);
        return this;
    }
    public Structure AddRoom(Room room)
    {
        Rooms.Add(room);
        return this;
    }
}
