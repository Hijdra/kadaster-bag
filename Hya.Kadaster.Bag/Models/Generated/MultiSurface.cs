using System.Runtime.Serialization;
using System.Text;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class MultiSurface : MultipolygonGeoJSON
{
    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MultiSurface {\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}