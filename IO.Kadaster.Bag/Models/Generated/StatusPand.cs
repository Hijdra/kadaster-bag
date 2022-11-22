using System.Runtime.Serialization;
using System.Text;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een codering van de verschillende waarden die de status van een pand kan aannemen.
/// </summary>
[DataContract]
public class StatusPand
{
    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class StatusPand {\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}