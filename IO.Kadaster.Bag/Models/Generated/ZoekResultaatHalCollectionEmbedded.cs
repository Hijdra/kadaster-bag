using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class ZoekResultaatHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Zoekresultaten
    /// </summary>
    [DataMember(Name = "zoekresultaten", EmitDefaultValue = false)]
    [JsonPropertyName("zoekresultaten")]
    public List<ZoekResultaatHal> Zoekresultaten { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ZoekResultaatHalCollectionEmbedded {\n");
        sb.Append("  Zoekresultaten: ").Append(Zoekresultaten).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}