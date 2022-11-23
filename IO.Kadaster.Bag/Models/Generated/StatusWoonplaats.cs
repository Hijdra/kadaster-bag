using System.Runtime.Serialization;
using System.Text;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een aanduiding van alle waarden die de status van een woonplaats kan aannemen.
/// </summary>
[DataContract]
public class StatusWoonplaats
{
    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class StatusWoonplaats {\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}