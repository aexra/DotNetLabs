using Lab4.Classes.Model.Base;

namespace Lab4.Classes.Model.Sources;
internal class DieselGenerator : ElectricSource
{
    public DieselGenerator(double voltage = 220, double powerLimit = 0) : base(voltage, powerLimit)
    {

    }
}
