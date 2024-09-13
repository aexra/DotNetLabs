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
}
