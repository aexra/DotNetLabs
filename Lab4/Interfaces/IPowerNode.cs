namespace Lab4.Interfaces;
internal interface IPowerNode
{
    public List<IElectricSource> Sources { get; }
    public List<IElectricConsumer> Consumers { get; }

    public double Capacity { get; }

    public delegate void FuzeBrokenHandler(IPowerNode node, double powerUsed);
    public delegate void SourceConnectedHandler(IPowerNode node, IElectricSource source);
    public delegate void SourceDisconnectedHandler(IPowerNode node, IElectricSource source);
    public delegate void ConsumerConnectedHandler(IPowerNode node, IElectricConsumer consumer);
    public delegate void ConsumerDisconnectedHandler(IPowerNode node, IElectricConsumer consumer);

    public event FuzeBrokenHandler FuzeBroken;
    public event SourceConnectedHandler SourceConnected;
    public event SourceDisconnectedHandler SourceDisconnected;
    public event ConsumerConnectedHandler ConsumerConnected;
    public event ConsumerDisconnectedHandler ConsumerDisconnected;

    public IPowerNode Run(out double powerUsed);
    public IPowerNode Connect(IElectricSource source);
    public IPowerNode Disonnect(IElectricSource source);
    public IPowerNode Connect(IElectricConsumer consumer);
    public IPowerNode Disconnect(IElectricConsumer consumer);
}
