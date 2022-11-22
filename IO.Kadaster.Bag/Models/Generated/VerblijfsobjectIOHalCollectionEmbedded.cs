using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class VerblijfsobjectIOHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Verblijfsobjecten
    /// </summary>
    [DataMember(Name = "verblijfsobjecten", EmitDefaultValue = false)]
    [JsonPropertyName("verblijfsobjecten")]
    public List<VerblijfsobjectIOHal> Verblijfsobjecten { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VerblijfsobjectIOHalCollectionEmbedded {\n");
        sb.Append("  Verblijfsobjecten: ").Append(Verblijfsobjecten).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}