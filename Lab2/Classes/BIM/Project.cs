using Lab2.Classes.BIM.Base;
using Lab2.Classes.BIM.Objects.Base;

namespace Lab2.Classes.BIM;
internal class Project
{
    private ProjectBuilder _settings = new();

    public List<Structure> Structures { get; private set; }

    public Project()
    {
        Structures = new();
    }

    public Project Configure(Action<ProjectBuilder> projectBuilder)
    {
        projectBuilder(_settings);
        return this;
    }
    public Project Build()
    {
        // Save project file somewhere using FileSavePicker
        return this;
    }

    public Project AddStructure(Structure structure)
    {
        Structures.Add(structure);
        return this;
    }

    public BIMObject? Find(string name)
    {
        return (BIMObject)Structures.Find(s => s.Name == name) ?? 
            (BIMObject)Structures.SelectMany(s => s.Rooms).ToList().Find(r => r.Name == name) ?? 
            (BIMObject)Structures.SelectMany(s => s.Rooms).ToList().SelectMany(r => r.Furnitures).ToList().Find(f => f.Name == name) ?? 
            null;
    }
}
