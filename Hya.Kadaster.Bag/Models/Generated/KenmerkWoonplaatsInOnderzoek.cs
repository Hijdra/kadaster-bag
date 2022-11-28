using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Limitatieve opsomming van alle kenmerken van dit object die in onderzoek zijn op dit moment,  of van alle kenmerken
///     die ooit in onderzoek zijn geweest als er een tijdreisvraag is gesteld  of een vraag naar de levenscyclus.
/// </summary>
[DataContract]
public class KenmerkWoonplaatsInOnderzoek
{
    /// <summary>
    ///     Gets or Sets Kenmerk
    /// </summary>
    [DataMember(Name = "kenmerk", EmitDefaultValue = false)]
    [JsonPropertyName("kenmerk")]
    public InOnderzoekWoonplaats Kenmerk { get; set; }

    /// <summary>
    ///     Gets or Sets IdentificatieVanWoonplaats
    /// </summary>
    [DataMember(Name = "identificatieVanWoonplaats", EmitDefaultValue = false)]
    [JsonPropertyName("identificatieVanWoonplaats")]
    public string IdentificatieVanWoonplaats { get; set; }

    /// <summary>
    ///     Gets or Sets InOnderzoek
    /// </summary>
    [DataMember(Name = "inOnderzoek", EmitDefaultValue = false)]
    [JsonPropertyName("inOnderzoek")]
    public Indicatie InOnderzoek { get; set; }

    /// <summary>
    ///     Gets or Sets Historie
    /// </summary>
    [DataMember(Name = "historie", EmitDefaultValue = false)]
    [JsonPropertyName("historie")]
    public HistorieInOnderzoek Historie { get; set; }

    /// <summary>
    ///     De datum van het document waarin de grondslag van het onderzoek wordt vastgelegd. Dit wordt vastgelegd in het
    ///     attribuut documentdatum.
    /// </summary>
    /// <value>
    ///     De datum van het document waarin de grondslag van het onderzoek wordt vastgelegd. Dit wordt vastgelegd in het
    ///     attribuut documentdatum.
    /// </value>
    [DataMember(Name = "documentdatum", EmitDefaultValue = false)]
    [JsonPropertyName("documentdatum")]
    public DateTime? Documentdatum { get; set; }

    /// <summary>
    ///     Het nummer van het document waarin de grondslag van het onderzoek wordt vastgelegd. Dit wordt vastgelegd in het
    ///     attribuut documentnummer.
    /// </summary>
    /// <value>
    ///     Het nummer van het document waarin de grondslag van het onderzoek wordt vastgelegd. Dit wordt vastgelegd in het
    ///     attribuut documentnummer.
    /// </value>
    [DataMember(Name = "documentnummer", EmitDefaultValue = false)]
    [JsonPropertyName("documentnummer")]
    public string Documentnummer { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KenmerkWoonplaatsInOnderzoek {\n");
        sb.Append("  Kenmerk: ").Append(Kenmerk).Append("\n");
        sb.Append("  IdentificatieVanWoonplaats: ").Append(IdentificatieVanWoonplaats).Append("\n");
        sb.Append("  InOnderzoek: ").Append(InOnderzoek).Append("\n");
        sb.Append("  Historie: ").Append(Historie).Append("\n");
        sb.Append("  Documentdatum: ").Append(Documentdatum).Append("\n");
        sb.Append("  Documentnummer: ").Append(Documentnummer).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}