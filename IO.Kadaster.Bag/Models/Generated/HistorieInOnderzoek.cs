using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class HistorieInOnderzoek
{
    /// <summary>
    ///     Het tijdstip waarop een versie van een onderzoek naar een attribuut van en BAG-object is geregistreerd in de
    ///     registratie van een bronhouder en daarmee authentiek wordt gemaakt.
    /// </summary>
    /// <value>
    ///     Het tijdstip waarop een versie van een onderzoek naar een attribuut van en BAG-object is geregistreerd in de
    ///     registratie van een bronhouder en daarmee authentiek wordt gemaakt.
    /// </value>
    [DataMember(Name = "tijdstipRegistratie", EmitDefaultValue = false)]
    [JsonPropertyName("tijdstipRegistratie")]
    public DateTime? TijdstipRegistratie { get; set; }

    /// <summary>
    ///     Het tijdstip waarop een versie van een onderzoek naar een attribuut van een BAG-object is beëindigd in de
    ///     registratie van een bronhouder.
    /// </summary>
    /// <value>
    ///     Het tijdstip waarop een versie van een onderzoek naar een attribuut van een BAG-object is beëindigd in de
    ///     registratie van een bronhouder.
    /// </value>
    [DataMember(Name = "eindRegistratie", EmitDefaultValue = false)]
    [JsonPropertyName("eindRegistratie")]
    public DateTime? EindRegistratie { get; set; }

    /// <summary>
    ///     De datum waarop een versie van een onderzoek naar een attribuut van een BAG-object geldig is in de werkelijkheid
    ///     conform de ingangsdatum in het brondocument. Als er geen expliciete ingangsdatum van geldigheid is opgenomen, wordt
    ///     de datum van het brondocument overgenomen.
    /// </summary>
    /// <value>
    ///     De datum waarop een versie van een onderzoek naar een attribuut van een BAG-object geldig is in de werkelijkheid
    ///     conform de ingangsdatum in het brondocument. Als er geen expliciete ingangsdatum van geldigheid is opgenomen, wordt
    ///     de datum van het brondocument overgenomen.
    /// </value>
    [DataMember(Name = "beginGeldigheid", EmitDefaultValue = false)]
    [JsonPropertyName("beginGeldigheid")]
    public DateTime? BeginGeldigheid { get; set; }

    /// <summary>
    ///     De datum waarop de periode van geldigheid van een versie van een onderzoek naar een attribuut van een BAG-object
    ///     eindigt. Bijvoorbeeld als gevolg van de vaststelling van een nieuw brondocument. Wanneer er geen tijdstip is
    ///     ingevuld, dan is de versie nog geldig.
    /// </summary>
    /// <value>
    ///     De datum waarop de periode van geldigheid van een versie van een onderzoek naar een attribuut van een BAG-object
    ///     eindigt. Bijvoorbeeld als gevolg van de vaststelling van een nieuw brondocument. Wanneer er geen tijdstip is
    ///     ingevuld, dan is de versie nog geldig.
    /// </value>
    [DataMember(Name = "eindGeldigheid", EmitDefaultValue = false)]
    [JsonPropertyName("eindGeldigheid")]
    public DateTime? EindGeldigheid { get; set; }

    /// <summary>
    ///     Dit is het tijdstip waarop een versie van een onderzoek naar een attribuut van een BAG-object is opgenomen in de
    ///     registratie van de landelijke voorziening. De gegevens komen daarmee beschikbaar voor afnemers.
    /// </summary>
    /// <value>
    ///     Dit is het tijdstip waarop een versie van een onderzoek naar een attribuut van een BAG-object is opgenomen in de
    ///     registratie van de landelijke voorziening. De gegevens komen daarmee beschikbaar voor afnemers.
    /// </value>
    [DataMember(Name = "tijdstipRegistratieLV", EmitDefaultValue = false)]
    [JsonPropertyName("tijdstipRegistratieLV")]
    public DateTime? TijdstipRegistratieLV { get; set; }

    /// <summary>
    ///     Dit is het tijdstip waarop een versie van een onderzoek naar een attribuut van een BAG-object is beëindigd in de
    ///     registratie van de landelijke voorziening.
    /// </summary>
    /// <value>
    ///     Dit is het tijdstip waarop een versie van een onderzoek naar een attribuut van een BAG-object is beëindigd in de
    ///     registratie van de landelijke voorziening.
    /// </value>
    [DataMember(Name = "tijdstipEindRegistratieLV", EmitDefaultValue = false)]
    [JsonPropertyName("tijdstipEindRegistratieLV")]
    public DateTime? TijdstipEindRegistratieLV { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistorieInOnderzoek {\n");
        sb.Append("  TijdstipRegistratie: ").Append(TijdstipRegistratie).Append("\n");
        sb.Append("  EindRegistratie: ").Append(EindRegistratie).Append("\n");
        sb.Append("  BeginGeldigheid: ").Append(BeginGeldigheid).Append("\n");
        sb.Append("  EindGeldigheid: ").Append(EindGeldigheid).Append("\n");
        sb.Append("  TijdstipRegistratieLV: ").Append(TijdstipRegistratieLV).Append("\n");
        sb.Append("  TijdstipEindRegistratieLV: ").Append(TijdstipEindRegistratieLV).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}