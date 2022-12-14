using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class VoorkomenLV : Voorkomen
{
    /// <summary>
    ///     Het tijdstip waarop een versie van een BAG-object is geregistreerd in de registratie van een bronhouder en daarmee
    ///     authentiek wordt gemaakt.
    /// </summary>
    /// <value>
    ///     Het tijdstip waarop een versie van een BAG-object is geregistreerd in de registratie van een bronhouder en
    ///     daarmee authentiek wordt gemaakt.
    /// </value>
    [DataMember(Name = "tijdstipRegistratie", EmitDefaultValue = false)]
    [JsonPropertyName("tijdstipRegistratie")]
    public DateTime? TijdstipRegistratie { get; set; }

    /// <summary>
    ///     De identificatie van een voorkomen van een object.
    /// </summary>
    /// <value>De identificatie van een voorkomen van een object.</value>
    [DataMember(Name = "versie", EmitDefaultValue = false)]
    [JsonPropertyName("versie")]
    public int? Versie { get; set; }

    /// <summary>
    ///     Het tijdstip waarop een versie van een BAG-object is beëindigd in de registratie van een bronhouder.
    /// </summary>
    /// <value>Het tijdstip waarop een versie van een BAG-object is beëindigd in de registratie van een bronhouder.</value>
    [DataMember(Name = "eindRegistratie", EmitDefaultValue = false)]
    [JsonPropertyName("eindRegistratie")]
    public DateTime? EindRegistratie { get; set; }

    /// <summary>
    ///     De datum waarop een versie van een BAG-object geldig is in de werkelijkheid conform de ingangsdatum in het
    ///     brondocument. Dit tijdstip wordt vastgelegd in de beginGeldigheid. Als er geen expliciete ingangsdatum van
    ///     geldigheid is opgenomen, wordt de datum van het brondocument overgenomen.
    /// </summary>
    /// <value>
    ///     De datum waarop een versie van een BAG-object geldig is in de werkelijkheid conform de ingangsdatum in het
    ///     brondocument. Dit tijdstip wordt vastgelegd in de beginGeldigheid. Als er geen expliciete ingangsdatum van
    ///     geldigheid is opgenomen, wordt de datum van het brondocument overgenomen.
    /// </value>
    [DataMember(Name = "beginGeldigheid", EmitDefaultValue = false)]
    [JsonPropertyName("beginGeldigheid")]
    public DateTime? BeginGeldigheid { get; set; }

    /// <summary>
    ///     De datum waarop de periode van geldigheid van een versie van een BAG-object eindigt. Bijvoorbeeld als gevolg van de
    ///     vaststelling van een nieuw brondocument. Wanneer er geen tijdstip is ingevuld, dan is de versie nog geldig.
    /// </summary>
    /// <value>
    ///     De datum waarop de periode van geldigheid van een versie van een BAG-object eindigt. Bijvoorbeeld als gevolg van
    ///     de vaststelling van een nieuw brondocument. Wanneer er geen tijdstip is ingevuld, dan is de versie nog geldig.
    /// </value>
    [DataMember(Name = "eindGeldigheid", EmitDefaultValue = false)]
    [JsonPropertyName("eindGeldigheid")]
    public DateTime? EindGeldigheid { get; set; }

    /// <summary>
    ///     Het tijdstip waarop een op dat moment toekomstig voorkomen door een bronhouder uit de geldige levenscylcus in de LV
    ///     BAG is verwijderd.
    /// </summary>
    /// <value>
    ///     Het tijdstip waarop een op dat moment toekomstig voorkomen door een bronhouder uit de geldige levenscylcus in de
    ///     LV BAG is verwijderd.
    /// </value>
    [DataMember(Name = "tijdstipInactief", EmitDefaultValue = false)]
    [JsonPropertyName("tijdstipInactief")]
    public DateTime? TijdstipInactief { get; set; }

    /// <summary>
    ///     Dit is het tijdstip waarop een versie van een BAG-object is opgenomen in de registratie van de landelijke
    ///     voorziening. De gegevens komen daarmee beschikbaar voor afnemers.
    /// </summary>
    /// <value>
    ///     Dit is het tijdstip waarop een versie van een BAG-object is opgenomen in de registratie van de landelijke
    ///     voorziening. De gegevens komen daarmee beschikbaar voor afnemers.
    /// </value>
    [DataMember(Name = "tijdstipRegistratieLV", EmitDefaultValue = false)]
    [JsonPropertyName("tijdstipRegistratieLV")]
    public DateTime? TijdstipRegistratieLV { get; set; }

    /// <summary>
    ///     Het tijdstip waarop een voorkomen door een synchronisatie bericht van een bronhouder is verwijderd uit de geldige
    ///     levenscylcus in de registratie van de landelijke voorziening.
    /// </summary>
    /// <value>
    ///     Het tijdstip waarop een voorkomen door een synchronisatie bericht van een bronhouder is verwijderd uit de
    ///     geldige levenscylcus in de registratie van de landelijke voorziening.
    /// </value>
    [DataMember(Name = "tijdstipNietBAG", EmitDefaultValue = false)]
    [JsonPropertyName("tijdstipNietBAG")]
    public DateTime? TijdstipNietBAG { get; set; }

    /// <summary>
    ///     Dit is het tijdstip waarop een versie van een BAG-object is beëindigd in de registratie van de landelijke
    ///     voorziening.
    /// </summary>
    /// <value>
    ///     Dit is het tijdstip waarop een versie van een BAG-object is beëindigd in de registratie van de landelijke
    ///     voorziening.
    /// </value>
    [DataMember(Name = "tijdstipEindRegistratieLV", EmitDefaultValue = false)]
    [JsonPropertyName("tijdstipEindRegistratieLV")]
    public DateTime? TijdstipEindRegistratieLV { get; set; }

    /// <summary>
    ///     Dit is het tijdstip waarop een toekomstig voorkomen van een BAG-object uit de geldige levenscylcus is verwijderd in
    ///     de registratie van de landelijke voorziening.
    /// </summary>
    /// <value>
    ///     Dit is het tijdstip waarop een toekomstig voorkomen van een BAG-object uit de geldige levenscylcus is verwijderd
    ///     in de registratie van de landelijke voorziening.
    /// </value>
    [DataMember(Name = "tijdstipInactiefLV", EmitDefaultValue = false)]
    [JsonPropertyName("tijdstipInactiefLV")]
    public DateTime? TijdstipInactiefLV { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VoorkomenLV {\n");
        sb.Append("  TijdstipRegistratie: ").Append(TijdstipRegistratie).Append("\n");
        sb.Append("  Versie: ").Append(Versie).Append("\n");
        sb.Append("  EindRegistratie: ").Append(EindRegistratie).Append("\n");
        sb.Append("  BeginGeldigheid: ").Append(BeginGeldigheid).Append("\n");
        sb.Append("  EindGeldigheid: ").Append(EindGeldigheid).Append("\n");
        sb.Append("  TijdstipInactief: ").Append(TijdstipInactief).Append("\n");
        sb.Append("  TijdstipRegistratieLV: ").Append(TijdstipRegistratieLV).Append("\n");
        sb.Append("  TijdstipNietBAG: ").Append(TijdstipNietBAG).Append("\n");
        sb.Append("  TijdstipEindRegistratieLV: ").Append(TijdstipEindRegistratieLV).Append("\n");
        sb.Append("  TijdstipInactiefLV: ").Append(TijdstipInactiefLV).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}