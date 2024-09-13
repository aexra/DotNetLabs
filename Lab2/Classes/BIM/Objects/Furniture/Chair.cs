namespace Lab2.Classes.BIM.Objects.Furniture;
internal class Chair : Base.Furniture
{
    public bool IsSwinging { get; set; } = false;
    public bool HasArmrests { get; set; } = true;

    public Chair Configure(Action<Chair> chairBuilder)
    {
        chairBuilder(this);
        return this;
    }
}
