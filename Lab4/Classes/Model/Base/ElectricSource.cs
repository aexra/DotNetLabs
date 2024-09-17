using Lab4.Interfaces;

namespace Lab4.Classes.Model.Base;
internal class ElectricSource : IElectricSource
{
    public double Voltage { get; set; }
    public double PowerLimit { get; set; }
    public List<IElectricConsumer> Consumers { get; private set; }

    public event IElectricSource.ConsumerConnectedHandler ConsumerConnected;
    public event IElectricSource.ConsumerDisconnectedHandler ConsumerDisconnected;

    public ElectricSource(double voltage = 220, double powerLimit = 0)
    {
        Voltage = voltage;
        PowerLimit = powerLimit;
        Consumers = new();
    }

    public IElectricSource Connect(IElectricConsumer consumer)
    {
        Consumers.Add(consumer);
        ConsumerConnected?.Invoke(this, consumer);
        return this;
    }
    public IElectricSource Disconnect(IElectricConsumer consumer)
    {
        Consumers.Remove(consumer);
        ConsumerDisconnected?.Invoke(this, consumer);
        return this;
    }
}
