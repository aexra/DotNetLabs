namespace Lab4.Interfaces;
internal interface IElectricConsumer
{
    public string Name { get; }
    public double Consumption { get; }

    public double Consume(IPowerNode node);
}
