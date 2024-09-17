using Lab4.Interfaces;

namespace Lab4.Classes.Model.Base;
internal class ElectricConsumer : IElectricConsumer
{
    public string Name => throw new NotImplementedException();
    public double Consumption => throw new NotImplementedException();

    public double Consume(IPowerNode node)
    {
        if (this is IElectricStrip strip)
        {
            return strip.Consume(node);
        }

        return Consumption;
    }
}
