using Lab4.Interfaces;

namespace Lab4.Classes.Model.Base;
internal abstract class ElectricSource : IElectricSource
{
    public double Voltage { get; set; }
    public double PowerLimit { get; set; }

    public ElectricSource(double voltage = 220, double powerLimit = 0)
    {
        Voltage = voltage;
        PowerLimit = powerLimit;
    }
}
