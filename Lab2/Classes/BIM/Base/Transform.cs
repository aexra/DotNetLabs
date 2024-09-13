using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Lab2.Classes.BIM.Base;
internal class Transform
{
    [NotNull]
    public Vector3 Position;

    [NotNull]
    public Vector3 Scale;

    [NotNull]
    public Quaternion Rotation;

    public Transform()
    {
        Position = Vector3.Zero;
        Scale = Vector3.One;
        Rotation = Quaternion.Identity;
    }
}
