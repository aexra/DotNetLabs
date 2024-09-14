namespace Lab2.Classes.BIM.Objects.Base;
internal class ElectricalApplience : Furniture
{
    public uint VoltageLimit { get; set; }
    public bool IsBroken { get; set; } = false;

    public delegate void ExplodeHandler(ElectricalApplience app, uint voltage);
    public event ExplodeHandler Explode;

    public ElectricalApplience(uint voltageLimit = 220) : base()
    {
        VoltageLimit = voltageLimit;
    }

    public ElectricalApplience Push(uint voltage)
    {
        if (voltage > VoltageLimit)
        {
            IsBroken = true;
            Explode?.Invoke(this, voltage);
        }

        return this;
    }
}
