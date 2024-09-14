using Lab2.Classes.BIM;
using Lab2.Classes.BIM.Objects.Furniture;
using Lab2.Classes.BIM.Objects.Rooms;
using Lab2.Classes.BIM.Objects.Structures;

///
/// .NET Lab #2
/// Ver. 3 (19)
///
var project = ProjectManager.NewProject()
    .Configure(builder =>
    {
        builder.SetName("ШКХПроект.rvt")
            .SetDescription("Проект плана «Институт Опережащих Технологий \"Школа Икс\"»");
    })
    .Build();

project.AddStructure(new Building(2).Configure(building =>
{
    building.Transform.Position = new System.Numerics.Vector3(100.500f, 0, 164718.5959174f);

    building.AddRoom(new Kitchen().Configure(kitchen =>
    {
        kitchen.Transform.Position = new System.Numerics.Vector3(20, 14, 3);
        kitchen.Transform.Scale = new System.Numerics.Vector3(4, 3, 3);
        kitchen.Transform.Rotation = System.Numerics.Quaternion.CreateFromRotationMatrix(new System.Numerics.Matrix4x4()
        {
            M11 = 1, M12 = 0, M13 = 0, M14 = 0,
            M21 = 0, M22 = 1, M23 = 0, M24 = 0,
            M31 = 0, M32 = 0, M33 = 1, M34 = 0,
            M41 = 0, M42 = 0, M43 = 0, M44 = 1,
        });

        kitchen.AddFurniture(new Lantern(5).Configure(lantern =>
        {
            lantern.IsLighting = true;

            lantern.Name = "Лампа над плитой";
        }))
        .AddFurniture(new Chair().Configure(chair =>
        {
            chair.IsSwinging = true;
            chair.HasArmrests = false;

            chair.Name = "Кресло у стола";
        }))
        .AddFurniture(new Refrigerator().Configure(fridge =>
        {
            fridge.Shelves = 8;
            fridge.DoorShelves = 10;
            fridge.DoubleDoored = true;
            fridge.HasFreezer = true;
            fridge.HasVegetablesSection = true;

            fridge.Name = "Холодильник";
        }))
        .AddFurniture(new Door().Configure(door =>
        {
            door.Transform.Scale = new System.Numerics.Vector3(1, 2, 0.2f);
        }))
        .AddFurniture(new Window().Configure(window =>
        {
            window.Transform.Scale = new System.Numerics.Vector3(1, 1, 0.2f);
        }));
    }));
}));

var lamp = (Lantern)project.Find("Лампа над плитой");
lamp.Explode += (l, v) =>
{
    Console.WriteLine($"Lamp exploded with voltage {v} over limited {l.VoltageLimit}");
};

lamp.Push(200);
lamp.Push(400);