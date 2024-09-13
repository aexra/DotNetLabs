using Lab2.Classes.BIM.Base;

namespace Lab2.Classes.BIM.Objects.Base;
internal abstract class Room : BIMObject
{
    public List<Furniture> Furnitures { get; private set; }

    public Room() : base()
    {

    }

    public Room Configure(Action<Room> roomBuilder)
    {
        roomBuilder(this);
        return this;
    }
    public Room AddFurniture(Furniture furniture)
    {
        Furnitures.Add(furniture);
        return this;
    }
}
