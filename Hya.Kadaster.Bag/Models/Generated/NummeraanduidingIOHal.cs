using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Nummeraanduiding, aangevuld met een limitatieve opsomming van alle kenmerken van dit object die in onderzoek
///     zijn(als metadata). Bij een normale vraag wordt aangegeven welke kenmerken er op dit moment in onderzoek zijn. Bij
///     een tijdreisvraag wordt aangegeven welke gegevens er ooit in onderzoek zijn geweest. Bij een levenscyclus vraag
///     wordt aangegeven welke gegevens er ooit in onderzoek zijn geweest.
/// </summary>
[DataContract]
public class NummeraanduidingIOHal
{
    /// <summary>
    ///     Gets or Sets Nummeraanduiding
    /// </summary>
    [DataMember(Name = "nummeraanduiding", EmitDefaultValue = false)]
    [JsonPropertyName("nummeraanduiding")]
    public Nummeraanduiding Nummeraanduiding { get; set; }

    /// <summary>
    ///     Gets or Sets Inonderzoek
    /// </summary>
    [DataMember(Name = "inonderzoek", EmitDefaultValue = false)]
    [JsonPropertyName("inonderzoek")]
    public List<KenmerkNummeraanduidingInOnderzoek> Inonderzoek { get; set; }

    /// <summary>
    ///     Gets or Sets Embedded
    /// </summary>
    [DataMember(Name = "_embedded", EmitDefaultValue = false)]
    [JsonPropertyName("_embedded")]
    public NummeraanduidingEmbedded Embedded { get; set; }

    /// <summary>
    ///     Gets or Sets Links
    /// </summary>
    [DataMember(Name = "_links", EmitDefaultValue = false)]
    [JsonPropertyName("_links")]
    public NummeraanduidingLinks Links { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NummeraanduidingIOHal {\n");
        sb.Append("  Nummeraanduiding: ").Append(Nummeraanduiding).Append("\n");
        sb.Append("  Inonderzoek: ").Append(Inonderzoek).Append("\n");
        sb.Append("  Embedded: ").Append(Embedded).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}