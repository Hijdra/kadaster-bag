using System.Runtime.Serialization;
using System.Text;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een aanduiding van alle waarden die de status van een gemeente kan aannemen.
/// </summary>
[DataContract]
public class StatusGemeente
{
    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class StatusGemeente {\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}