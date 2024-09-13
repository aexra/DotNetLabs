using Lab2.Classes.BIM.Base;

namespace Lab2.Classes.BIM.Objects.Base;
internal abstract class Furniture : BIMObject
{
    public Furniture() : base()
    {

    }

    public Furniture Configure(Action<Furniture> furnitureBuilder)
    {
        furnitureBuilder(this);
        return this;
    }
}
