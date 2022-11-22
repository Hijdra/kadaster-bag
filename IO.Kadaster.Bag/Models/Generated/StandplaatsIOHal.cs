using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een verzameling van een Standplaats en een lijst van alle bijbehorende inonderzoek informatie.
/// </summary>
[DataContract]
public class StandplaatsIOHal
{
    /// <summary>
    ///     Gets or Sets Standplaats
    /// </summary>
    [DataMember(Name = "standplaats", EmitDefaultValue = false)]
    [JsonPropertyName("standplaats")]
    public Standplaats Standplaats { get; set; }

    /// <summary>
    ///     Gets or Sets Inonderzoek
    /// </summary>
    [DataMember(Name = "inonderzoek", EmitDefaultValue = false)]
    [JsonPropertyName("inonderzoek")]
    public List<KenmerkStandplaatsInOnderzoek> Inonderzoek { get; set; }

    /// <summary>
    ///     Gets or Sets Embedded
    /// </summary>
    [DataMember(Name = "_embedded", EmitDefaultValue = false)]
    [JsonPropertyName("_embedded")]
    public StandplaatsEmbedded Embedded { get; set; }

    /// <summary>
    ///     Gets or Sets Links
    /// </summary>
    [DataMember(Name = "_links", EmitDefaultValue = false)]
    [JsonPropertyName("_links")]
    public StandplaatsLinks Links { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class StandplaatsIOHal {\n");
        sb.Append("  Standplaats: ").Append(Standplaats).Append("\n");
        sb.Append("  Inonderzoek: ").Append(Inonderzoek).Append("\n");
        sb.Append("  Embedded: ").Append(Embedded).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}