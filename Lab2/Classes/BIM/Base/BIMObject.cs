using System.Diagnostics.CodeAnalysis;

namespace Lab2.Classes.BIM.Base;
internal abstract class BIMObject
{
    [NotNull]
    public Transform Transform { get; private set; }

    [NotNull]
    public string Name { get; set; }

    public BIMObject()
    {
        Transform = new Transform();
        Name = "Object (1)";
    }
}
