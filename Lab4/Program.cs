using Lab4.Classes.Model;
using Lab4.Classes.Model.Consumers;
using Lab4.Classes.Model.Sources;

var node = new PowerNode(
    new SolarBattery(powerLimit: 100),   
    new SolarBattery(powerLimit: 100),
    new SolarBattery(powerLimit: 100),
    new SolarBattery(powerLimit: 100),
    new NuclearPowerPlant(powerLimit: 10000)
);

node.Connect(new Kettle())
    .Connect(new Kettle());

node.Run(out var powerUsed);

Console.WriteLine($"Power used: {powerUsed}");