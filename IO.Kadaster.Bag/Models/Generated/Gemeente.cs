using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een bronhouder is een gemeente of samenwerkingsverband van gemeenten en  heeft een code en naam net als een
///     gemeente.
/// </summary>
[DataContract]
public class Gemeente
{
    /// <summary>
    ///     Een officiële code die aan een gemeente is toegekend, ontleend is aan  tabel 33 en zoals bijgehouden in de LVBAG.
    ///     Dit gegeven is geen officieel BAG gegeven en wordt niet als kenmerk van  het BAG object Woonplaats object
    ///     bijgehouden.  Het wordt als hulpgegeven meegeleverd.
    /// </summary>
    /// <value>
    ///     Een officiële code die aan een gemeente is toegekend, ontleend is aan  tabel 33 en zoals bijgehouden in de
    ///     LVBAG.  Dit gegeven is geen officieel BAG gegeven en wordt niet als kenmerk van  het BAG object Woonplaats object
    ///     bijgehouden.  Het wordt als hulpgegeven meegeleverd.
    /// </value>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    [JsonPropertyName("code")]
    public string Code { get; set; }

    /// <summary>
    ///     Een officiële naam die aan een gemeente is toegekend.
    /// </summary>
    /// <value>Een officiële naam die aan een gemeente is toegekend.</value>
    [DataMember(Name = "naam", EmitDefaultValue = false)]
    [JsonPropertyName("naam")]
    public string Naam { get; set; }

    /// <summary>
    ///     De datum waarop een versie van een bronhouder geldig is in de werkelijkheid.  Dit tijdstip wordt vastgelegd in de
    ///     beginGeldigheid.
    /// </summary>
    /// <value>
    ///     De datum waarop een versie van een bronhouder geldig is in de werkelijkheid.  Dit tijdstip wordt vastgelegd in
    ///     de beginGeldigheid.
    /// </value>
    [DataMember(Name = "beginGeldigheid", EmitDefaultValue = false)]
    [JsonPropertyName("beginGeldigheid")]
    public DateTime? BeginGeldigheid { get; set; }

    /// <summary>
    ///     De datum waarop de periode van geldigheid van een versie van een bronhouder  eindigt.  Wanneer er geen tijdstip is
    ///     ingevuld, dan is de versie nog geldig.  Dit tijdstip wordt vastgelegd in de eindGeldigheid.
    /// </summary>
    /// <value>
    ///     De datum waarop de periode van geldigheid van een versie van een bronhouder  eindigt.  Wanneer er geen tijdstip
    ///     is ingevuld, dan is de versie nog geldig.  Dit tijdstip wordt vastgelegd in de eindGeldigheid.
    /// </value>
    [DataMember(Name = "eindGeldigheid", EmitDefaultValue = false)]
    [JsonPropertyName("eindGeldigheid")]
    public DateTime? EindGeldigheid { get; set; }

    /// <summary>
    ///     Gets or Sets Provincie
    /// </summary>
    [DataMember(Name = "provincie", EmitDefaultValue = false)]
    [JsonPropertyName("provincie")]
    public Provincie Provincie { get; set; }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonPropertyName("status")]
    public StatusGemeente Status { get; set; }

    /// <summary>
    ///     De identificatie van een voorkomen van een object.
    /// </summary>
    /// <value>De identificatie van een voorkomen van een object.</value>
    [DataMember(Name = "versie", EmitDefaultValue = false)]
    [JsonPropertyName("versie")]
    public int? Versie { get; set; }

    /// <summary>
    ///     Dit is het tijdstip (conform RFC 3339) waarop een versie van een object of een relatie is opgenomen in de
    ///     registratie van de landelijke voorziening. De gegevens komen daarmee beschikbaar voor afnemers.
    /// </summary>
    /// <value>
    ///     Dit is het tijdstip (conform RFC 3339) waarop een versie van een object of een relatie is opgenomen in de
    ///     registratie van de landelijke voorziening. De gegevens komen daarmee beschikbaar voor afnemers.
    /// </value>
    [DataMember(Name = "tijdstipRegistratieLV", EmitDefaultValue = false)]
    [JsonPropertyName("tijdstipRegistratieLV")]
    public DateTime? TijdstipRegistratieLV { get; set; }

    /// <summary>
    ///     Dit is het tijdstip (conform RFC 3339) waarop een versie van een object of een relatie is beëindigd in de
    ///     registratie van de landelijke voorziening.
    /// </summary>
    /// <value>
    ///     Dit is het tijdstip (conform RFC 3339) waarop een versie van een object of een relatie is beëindigd in de
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
        sb.Append("class Gemeente {\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Naam: ").Append(Naam).Append("\n");
        sb.Append("  BeginGeldigheid: ").Append(BeginGeldigheid).Append("\n");
        sb.Append("  EindGeldigheid: ").Append(EindGeldigheid).Append("\n");
        sb.Append("  Provincie: ").Append(Provincie).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Versie: ").Append(Versie).Append("\n");
        sb.Append("  TijdstipRegistratieLV: ").Append(TijdstipRegistratieLV).Append("\n");
        sb.Append("  TijdstipEindRegistratieLV: ").Append(TijdstipEindRegistratieLV).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}