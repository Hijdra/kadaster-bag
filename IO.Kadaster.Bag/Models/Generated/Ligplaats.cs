using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een Ligplaats is een door het bevoegde gemeentelijke orgaan als zodanig aangewezen plaats in het water al dan niet
///     aangevuld met een op de oever aanwezig terrein of een gedeelte daarvan, die bestemd is voor het permanent afmeren
///     van een voor woon-, bedrijfsmatige of recreatieve doeleinden geschikt drijvend object.
/// </summary>
[DataContract]
public class Ligplaats : AdresseerbaarObject
{
    /// <summary>
    ///     Gets or Sets Identificatie
    /// </summary>
    [DataMember(Name = "identificatie", EmitDefaultValue = false)]
    [JsonPropertyName("identificatie")]
    public string Identificatie { get; set; }

    /// <summary>
    ///     NL.IMBAG.Ligplaats
    /// </summary>
    /// <value>NL.IMBAG.Ligplaats</value>
    [DataMember(Name = "domein", EmitDefaultValue = false)]
    [JsonPropertyName("domein")]
    public string Domein { get; set; }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonPropertyName("status")]
    public StatusPlaats Status { get; set; }

    /// <summary>
    ///     Gets or Sets Geometrie
    /// </summary>
    [DataMember(Name = "geometrie", EmitDefaultValue = false)]
    [JsonPropertyName("geometrie")]
    public Surface Geometrie { get; set; }

    /// <summary>
    ///     Gets or Sets Geconstateerd
    /// </summary>
    [DataMember(Name = "geconstateerd", EmitDefaultValue = false)]
    [JsonPropertyName("geconstateerd")]
    public Indicatie Geconstateerd { get; set; }

    /// <summary>
    ///     De datum waarop het brondocument is vastgesteld, op basis waarvan een  opname, mutatie of een verwijdering van
    ///     gegevens ten aanzien van een  object heeft plaatsgevonden.
    /// </summary>
    /// <value>
    ///     De datum waarop het brondocument is vastgesteld, op basis waarvan een  opname, mutatie of een verwijdering van
    ///     gegevens ten aanzien van een  object heeft plaatsgevonden.
    /// </value>
    [DataMember(Name = "documentdatum", EmitDefaultValue = false)]
    [JsonPropertyName("documentdatum")]
    public DateTime? Documentdatum { get; set; }

    /// <summary>
    ///     De unieke aanduiding van het brondocument op basis waarvan een opname,  mutatie of een verwijdering van gegevens
    ///     ten aanzien van een woonplaats  heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1  karakterset
    ///     zijn toegestaan.
    /// </summary>
    /// <value>
    ///     De unieke aanduiding van het brondocument op basis waarvan een opname,  mutatie of een verwijdering van gegevens
    ///     ten aanzien van een woonplaats  heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1  karakterset
    ///     zijn toegestaan.
    /// </value>
    [DataMember(Name = "documentnummer", EmitDefaultValue = false)]
    [JsonPropertyName("documentnummer")]
    public string Documentnummer { get; set; }

    /// <summary>
    ///     Gets or Sets Voorkomen
    /// </summary>
    [DataMember(Name = "voorkomen", EmitDefaultValue = false)]
    [JsonPropertyName("voorkomen")]
    public VoorkomenLV Voorkomen { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Ligplaats {\n");
        sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
        sb.Append("  Domein: ").Append(Domein).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Geometrie: ").Append(Geometrie).Append("\n");
        sb.Append("  Geconstateerd: ").Append(Geconstateerd).Append("\n");
        sb.Append("  Documentdatum: ").Append(Documentdatum).Append("\n");
        sb.Append("  Documentnummer: ").Append(Documentnummer).Append("\n");
        sb.Append("  Voorkomen: ").Append(Voorkomen).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}