namespace Lab2.Classes.BIM.Objects.Furniture;
internal class Lantern : Base.ElectricalApplience
{
    private bool _isLighting = false;
    public bool IsLighting
    {
        get => _isLighting;
        set
        {
            if (Lamps > 0 && value == true)
            {
                _isLighting = true;
            }
            else
            {
                _isLighting = false;
            }
        }
    }
    public uint Lamps { get; private set; } = 1;

    public Lantern(uint lamps = 1, uint voltage = 220) : base(voltage)
    {
        Lamps = lamps;
    }

    public Lantern Configure(Action<Lantern> lanternBuilder)
    {
        lanternBuilder(this);
        return this;
    }
}
