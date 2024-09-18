using Lab4.Classes.Model;
using Lab4.Classes.Model.Consumers;
using Lab4.Classes.Model.Sources;
using Lab4.Classes.Model.Strips;

var node = new PowerNode(
    new SolarBattery(powerLimit: 100),   
    new SolarBattery(powerLimit: 100),
    new SolarBattery(powerLimit: 100),
    new SolarBattery(powerLimit: 100),
    new NuclearPowerPlant(powerLimit: 10000)
);

node.Connect(new Kettle())
    .Connect(new Kettle())
    .Connect(new ElectricStrip(2, new Kettle(), new Kettle()));

node.Run(out var powerUsed);

Console.WriteLine($"Power used: {powerUsed}");