namespace Lab4.Interfaces;
internal interface IElectricStrip : IElectricConsumer
{
    public List<IElectricConsumer> Consumers { get; }
    public uint ConsumersLimit { get; }
}
