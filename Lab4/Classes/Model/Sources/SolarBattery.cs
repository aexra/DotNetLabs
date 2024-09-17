using Lab4.Classes.Model.Base;

namespace Lab4.Classes.Model.Sources;
internal class SolarBattery : ElectricSource
{
    public SolarBattery(double voltage = 220, double powerLimit = 0) : base(voltage, powerLimit)
    {

    }
}
