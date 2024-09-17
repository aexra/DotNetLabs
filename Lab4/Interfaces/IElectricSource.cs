namespace Lab4.Interfaces;
internal interface IElectricSource
{
    public double Voltage { get; }
    public double PowerLimit { get; }
    public List<IElectricConsumer> Consumers { get; }

    public delegate void ConsumerConnectedHandler(IElectricSource source, IElectricConsumer consumer);
    public delegate void ConsumerDisconnectedHandler(IElectricSource source, IElectricConsumer consumer);

    public event ConsumerConnectedHandler ConsumerConnected;
    public event ConsumerDisconnectedHandler ConsumerDisconnected;

    public IElectricSource Connect(IElectricConsumer consumer);
    public IElectricSource Disconnect(IElectricConsumer consumer);
}
