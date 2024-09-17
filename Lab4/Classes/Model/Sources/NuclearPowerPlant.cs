using Lab4.Classes.Model.Base;

namespace Lab4.Classes.Model.Sources;
internal class NuclearPowerPlant : ElectricSource
{
    public NuclearPowerPlant(double voltage = 220, double powerLimit = 0) : base(voltage, powerLimit)
    {

    }
}
