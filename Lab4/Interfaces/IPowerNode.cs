namespace Lab4.Interfaces;
internal interface IPowerNode
{
    public List<IElectricSource> Sources { get; }

    public delegate void FuzeBrokenHandler(IPowerNode node);
    public delegate void SourceConnectedHandler(IPowerNode node, IElectricSource source);
    public delegate void SourceDisconnectedHandler(IPowerNode node, IElectricSource source);

    public event FuzeBrokenHandler FuzeBroken;
    public event SourceConnectedHandler SourceConnected;
    public event SourceDisconnectedHandler SourceDisconnected;

    public IPowerNode Run();
    public IPowerNode Connect(IElectricSource source);
    public IPowerNode Disonnect(IElectricSource source);
}
