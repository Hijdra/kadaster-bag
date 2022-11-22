using System.Runtime.Serialization;
using System.Text;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class Surface : PolygonGeoJSON
{
    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Surface {\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}