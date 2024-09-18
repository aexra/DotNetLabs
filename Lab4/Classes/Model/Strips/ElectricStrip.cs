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

    public ElectricStrip(uint consumersLimit = 1)
    {
        Consumers = new();
        ConsumersLimit = consumersLimit;
    }
    public ElectricStrip(uint consumersLimit = 1, params IElectricConsumer[] consumers) : this(consumersLimit)
    {
        Consumers = new(consumers);
        if (Consumers.Count > ConsumersLimit) throw(new Exception("Not enough consumer ports"));
    }

    public IElectricStrip Connect(IElectricConsumer consumer)
    {
        Consumers.Add(consumer);
        if (Consumers.Count > ConsumersLimit) throw (new Exception("Not enough consumer ports"));
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
