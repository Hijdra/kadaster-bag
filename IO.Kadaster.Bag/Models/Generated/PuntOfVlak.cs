using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een samengesteld geometriegegevenstype waarbij wordt afgedwongen dat voor de geometrie een  keuze gemaakt moet
///     worden tussen een punt of een vlak.
/// </summary>
[DataContract]
public class PuntOfVlak
{
    /// <summary>
    ///     Gets or Sets Punt
    /// </summary>
    [DataMember(Name = "punt", EmitDefaultValue = false)]
    [JsonPropertyName("punt")]
    public PointGeoJSON Punt { get; set; }

    /// <summary>
    ///     Gets or Sets Vlak
    /// </summary>
    [DataMember(Name = "vlak", EmitDefaultValue = false)]
    [JsonPropertyName("vlak")]
    public Surface Vlak { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PuntOfVlak {\n");
        sb.Append("  Punt: ").Append(Punt).Append("\n");
        sb.Append("  Vlak: ").Append(Vlak).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}