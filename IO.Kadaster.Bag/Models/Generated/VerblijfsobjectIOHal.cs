using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een verzameling van een verblijfsobject en een lijst van alle bijbehorende inonderzoek informatie.
/// </summary>
[DataContract]
public class VerblijfsobjectIOHal
{
    /// <summary>
    ///     Gets or Sets Verblijfsobject
    /// </summary>
    [DataMember(Name = "verblijfsobject", EmitDefaultValue = false)]
    [JsonPropertyName("verblijfsobject")]
    public Verblijfsobject Verblijfsobject { get; set; }

    /// <summary>
    ///     Gets or Sets Inonderzoek
    /// </summary>
    [DataMember(Name = "inonderzoek", EmitDefaultValue = false)]
    [JsonPropertyName("inonderzoek")]
    public List<KenmerkVerblijfsobjectInOnderzoek> Inonderzoek { get; set; }

    /// <summary>
    ///     Gets or Sets Embedded
    /// </summary>
    [DataMember(Name = "_embedded", EmitDefaultValue = false)]
    [JsonPropertyName("_embedded")]
    public VerblijfsobjectEmbedded Embedded { get; set; }

    /// <summary>
    ///     Gets or Sets Links
    /// </summary>
    [DataMember(Name = "_links", EmitDefaultValue = false)]
    [JsonPropertyName("_links")]
    public VerblijfsobjectLinks Links { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VerblijfsobjectIOHal {\n");
        sb.Append("  Verblijfsobject: ").Append(Verblijfsobject).Append("\n");
        sb.Append("  Inonderzoek: ").Append(Inonderzoek).Append("\n");
        sb.Append("  Embedded: ").Append(Embedded).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}