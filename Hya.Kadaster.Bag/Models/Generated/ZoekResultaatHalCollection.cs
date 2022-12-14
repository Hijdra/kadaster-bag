using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Resultaten als lijst
/// </summary>
[DataContract]
public class ZoekResultaatHalCollection
{
    /// <summary>
    ///     Gets or Sets Links
    /// </summary>
    [DataMember(Name = "_links", EmitDefaultValue = false)]
    [JsonPropertyName("_links")]
    public HalPaginationLinks Links { get; set; }

    /// <summary>
    ///     Gets or Sets Embedded
    /// </summary>
    [DataMember(Name = "_embedded", EmitDefaultValue = false)]
    [JsonPropertyName("_embedded")]
    public ZoekResultaatHalCollectionEmbedded Embedded { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ZoekResultaatHalCollection {\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("  Embedded: ").Append(Embedded).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}