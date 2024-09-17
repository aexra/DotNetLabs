using Lab4.Classes.Model;
using Lab4.Classes.Model.Sources;

var node = new PowerNode(
    new SolarBattery(powerLimit: 100),   
    new SolarBattery(powerLimit: 100),
    new SolarBattery(powerLimit: 100),
    new SolarBattery(powerLimit: 100),
    new NuclearPowerPlant(powerLimit: 10000)
        .Connect()
);