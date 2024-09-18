using Lab4.Interfaces;

namespace Lab4.Classes.Model.Base;
internal abstract class ElectricConsumer : IElectricConsumer
{
    public string Name { get; set; }
    public double Consumption { get; private set; }

    public ElectricConsumer(double consumption = 1)
    {
        Consumption = consumption;
    }

    public double Consume(IPowerNode node)
    {
        if (this is IElectricStrip strip)
        {
            return strip.Consume(node);
        }

        return Consumption;
    }
}
