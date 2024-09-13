namespace Lab2.Classes.BIM;
internal class ProjectBuilder
{
    public string Name { get; set; } = "NewProject";
    public string Description { get; set; } = string.Empty;

    public ProjectBuilder SetName(string name)
    {
        Name = name;
        return this;
    }
    public ProjectBuilder SetDescription(string description)
    {
        Description = description;
        return this;
    }
}
