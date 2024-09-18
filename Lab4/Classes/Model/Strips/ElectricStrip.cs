using Lab4.Interfaces;

namespace Lab4.Classes.Model.Strips;
internal class ElectricStrip : IElectricStrip
{
    public List<IElectricConsumer> Consumers { get; private set; }
    public uint ConsumersLimit { get; private set; }
    public string Name { get; private set; }

    public double Consumption => Consumers.Select(c => c.Consumption).Sum();

    public event IElectricStrip.ConsumerConnectedHandler ConsumerConnected;
    public event IElectricStrip.ConsumerDisconnectedHandler ConsumerDisconnected;

    public IElectricStrip Connect(IElectricConsumer consumer)
    {
        Consumers.Add(consumer);
        ConsumerConnected?.Invoke(this, consumer);
        return this;
    }
    public IElectricStrip Disonnect(IElectricConsumer consumer)
    {
        Consumers.Remove(consumer);
        ConsumerDisconnected?.Invoke(this, consumer);
        return this;
    }

    public double Consume(IPowerNode node)
    {
        return Consumers.Select(c => c.Consume(node)).Sum();
    }
}
