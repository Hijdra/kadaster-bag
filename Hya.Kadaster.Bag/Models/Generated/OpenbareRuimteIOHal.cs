using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Openbare ruimte, aangevuld met een limitatieve opsomming van alle kenmerken van dit object die in onderzoek
///     zijn(als metadata). Bij een normale vraag wordt aangegeven welke kenmerken er op dit moment in onderzoek zijn. Bij
///     een tijdreisvraag wordt aangegeven welke gegevens er ooit in onderzoek zijn geweest. Bij een levenscyclus vraag
///     wordt aangegeven welke gegevens er ooit in onderzoek zijn geweest.
/// </summary>
[DataContract]
public class OpenbareRuimteIOHal
{
    /// <summary>
    ///     Gets or Sets OpenbareRuimte
    /// </summary>
    [DataMember(Name = "openbareRuimte", EmitDefaultValue = false)]
    [JsonPropertyName("openbareRuimte")]
    public OpenbareRuimte OpenbareRuimte { get; set; }

    /// <summary>
    ///     Gets or Sets Inonderzoek
    /// </summary>
    [DataMember(Name = "inonderzoek", EmitDefaultValue = false)]
    [JsonPropertyName("inonderzoek")]
    public List<KenmerkOpenbareRuimteInOnderzoek> Inonderzoek { get; set; }

    /// <summary>
    ///     Gets or Sets Embedded
    /// </summary>
    [DataMember(Name = "_embedded", EmitDefaultValue = false)]
    [JsonPropertyName("_embedded")]
    public OpenbareRuimteEmbedded Embedded { get; set; }

    /// <summary>
    ///     Gets or Sets Links
    /// </summary>
    [DataMember(Name = "_links", EmitDefaultValue = false)]
    [JsonPropertyName("_links")]
    public OpenbareRuimteLinks Links { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenbareRuimteIOHal {\n");
        sb.Append("  OpenbareRuimte: ").Append(OpenbareRuimte).Append("\n");
        sb.Append("  Inonderzoek: ").Append(Inonderzoek).Append("\n");
        sb.Append("  Embedded: ").Append(Embedded).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}