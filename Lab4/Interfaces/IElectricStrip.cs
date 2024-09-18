namespace Lab4.Interfaces;
internal interface IElectricStrip : IElectricConsumer
{
    public List<IElectricConsumer> Consumers { get; }
    public uint ConsumersLimit { get; }

    public delegate void ConsumerConnectedHandler(IElectricStrip strip, IElectricConsumer consumer);
    public delegate void ConsumerDisconnectedHandler(IElectricStrip strip, IElectricConsumer consumer);

    public event ConsumerConnectedHandler ConsumerConnected;
    public event ConsumerDisconnectedHandler ConsumerDisconnected;

    public IElectricStrip Connect(IElectricConsumer consumer);
    public IElectricStrip Disonnect(IElectricConsumer consumer);
}
