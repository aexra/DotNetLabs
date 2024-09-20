using Lab4.Classes.Model.Base;
using Lab4.Interfaces;

namespace Lab4.Classes.Model;
internal class PowerNode : IPowerNode
{
    public List<IElectricSource> Sources { get; private set; }
    public List<IElectricConsumer> Consumers { get; private set; }

    public double Capacity => Sources.Select(s => s.PowerLimit).Sum();

    public PowerNode()
    {
        Sources = new();
        Consumers = new();
    }
    public PowerNode(params ElectricSource[] sources) : this()
    {
        Sources = new(sources);
    }

    public event IPowerNode.FuzeBrokenHandler FuzeBroken;
    public event IPowerNode.SourceConnectedHandler SourceConnected;
    public event IPowerNode.SourceDisconnectedHandler SourceDisconnected;
    public event IPowerNode.ConsumerConnectedHandler ConsumerConnected;
    public event IPowerNode.ConsumerDisconnectedHandler ConsumerDisconnected;

    public IPowerNode Run(out double powerUsed)
    {
        powerUsed = 0;

        foreach (var consumer in Consumers)
        {
            powerUsed += consumer.Consume(this);
        }

        if (powerUsed > Capacity)
        {
            FuzeBroken?.Invoke(this, powerUsed);
        }

        return this;
    }

    public IPowerNode Connect(IElectricSource source)
    {
        Sources.Add(source);
        SourceConnected?.Invoke(this, source);
        return this;
    }
    public IPowerNode Disonnect(IElectricSource source)
    {
        Sources.Remove(source);
        SourceDisconnected?.Invoke(this, source);
        return this;
    }

    public IPowerNode Connect(IElectricConsumer consumer)
    {
        Consumers.Add(consumer);
        ConsumerConnected?.Invoke(this, consumer);
        return this;
    }
    public IPowerNode Disconnect(IElectricConsumer consumer)
    {
        Consumers.Remove(consumer);
        ConsumerDisconnected?.Invoke(this, consumer);
        return this;
    }
}
