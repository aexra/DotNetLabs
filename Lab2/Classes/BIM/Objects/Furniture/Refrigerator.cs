namespace Lab2.Classes.BIM.Objects.Furniture;
internal class Refrigerator : Base.Furniture
{
    public bool HasFreezer { get; set; } = true;
    public bool HasVegetablesSection { get; set; } = true;
    public bool DoubleDoored { get; set; } = false;
    public uint Shelves = 4;
    public uint DoorShelves = 6;

    public Refrigerator Configure(Action<Refrigerator> refrigeratorBuilder)
    {
        refrigeratorBuilder(this);
        return this;
    }
}
