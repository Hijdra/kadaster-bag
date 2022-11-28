using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class ZoekResultaatHal : ZoekResultaat
{
    /// <summary>
    ///     Gets or Sets Links
    /// </summary>
    [DataMember(Name = "_links", EmitDefaultValue = false)]
    [JsonPropertyName("_links")]
    public ZoekResultaatLinks Links { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ZoekResultaatHal {\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}