using Lab4.Classes.Model.Base;
using Lab4.Interfaces;

namespace Lab4.Classes.Model;
internal class PowerNode : IPowerNode
{
    public List<IElectricSource> Sources { get; private set; }

    public PowerNode()
    {
        Sources = new();
    }
    public PowerNode(params ElectricSource[] sources)
    {
        Sources = new(sources);

        foreach (var source in Sources)
        {
            SourceConnected?.Invoke(this, source);
        }
    }

    public event IPowerNode.FuzeBrokenHandler FuzeBroken;
    public event IPowerNode.SourceConnectedHandler SourceConnected;
    public event IPowerNode.SourceDisconnectedHandler SourceDisconnected;

    public IPowerNode Run()
    {
        var powerLimit = Sources.Select(s => s.PowerLimit).Sum();
        var firstLayersConsumers = Sources.SelectMany(s => s.Consumers);

        double powerUsed = 0;

        foreach (var consumer in firstLayersConsumers)
        {
            powerUsed += consumer.Consume(this);
            if (powerUsed > powerLimit)
            {
                FuzeBroken?.Invoke(this);
                break;
            }
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
}
