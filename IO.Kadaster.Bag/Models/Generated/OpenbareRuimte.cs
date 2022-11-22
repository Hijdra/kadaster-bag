using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een Openbare ruimte is een door het bevoegde gemeentelijke orgaan als zodanig  aangewezen en van een naam voorziene
///     buitenruimte die binnen één woonplaats  is gelegen.
/// </summary>
[DataContract]
public class OpenbareRuimte
{
    /// <summary>
    ///     Gets or Sets Identificatie
    /// </summary>
    [DataMember(Name = "identificatie", EmitDefaultValue = false)]
    [JsonPropertyName("identificatie")]
    public string Identificatie { get; set; }

    /// <summary>
    ///     NL.IMBAG.Openbareruimte
    /// </summary>
    /// <value>NL.IMBAG.Openbareruimte</value>
    [DataMember(Name = "domein", EmitDefaultValue = false)]
    [JsonPropertyName("domein")]
    public string Domein { get; set; }

    /// <summary>
    ///     Een naam die aan een openbare ruimte is toegekend in een daartoe strekkend  formeel gemeentelijk besluit.
    /// </summary>
    /// <value>Een naam die aan een openbare ruimte is toegekend in een daartoe strekkend  formeel gemeentelijk besluit. </value>
    [DataMember(Name = "naam", EmitDefaultValue = false)]
    [JsonPropertyName("naam")]
    public string Naam { get; set; }

    /// <summary>
    ///     Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonPropertyName("type")]
    public TypeOpenbareRuimte Type { get; set; }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonPropertyName("status")]
    public StatusNaamgeving Status { get; set; }

    /// <summary>
    ///     De officiële openbare ruimte naam als deze niet langer is dan 24 tekens of  de volgens de NEN5825 verkorte naam van
    ///     maximaal 24 tekens.
    /// </summary>
    /// <value>
    ///     De officiële openbare ruimte naam als deze niet langer is dan 24 tekens of  de volgens de NEN5825 verkorte naam
    ///     van maximaal 24 tekens.
    /// </value>
    [DataMember(Name = "korteNaam", EmitDefaultValue = false)]
    [JsonPropertyName("korteNaam")]
    public string KorteNaam { get; set; }

    /// <summary>
    ///     Gets or Sets Geconstateerd
    /// </summary>
    [DataMember(Name = "geconstateerd", EmitDefaultValue = false)]
    [JsonPropertyName("geconstateerd")]
    public Indicatie Geconstateerd { get; set; }

    /// <summary>
    ///     De datum waarop het brondocument is vastgesteld, op basis waarvan een opname,  mutatie of een verwijdering van
    ///     gegevens ten aanzien van een object heeft  plaatsgevonden.
    /// </summary>
    /// <value>
    ///     De datum waarop het brondocument is vastgesteld, op basis waarvan een opname,  mutatie of een verwijdering van
    ///     gegevens ten aanzien van een object heeft  plaatsgevonden.
    /// </value>
    [DataMember(Name = "documentdatum", EmitDefaultValue = false)]
    [JsonPropertyName("documentdatum")]
    public DateTime? Documentdatum { get; set; }

    /// <summary>
    ///     De unieke aanduiding van het brondocument op basis waarvan een opname,  mutatie of een verwijdering van gegevens
    ///     ten aanzien van een woonplaats  heeft plaatsgevonden binnen een gemeente.  Alle karakters uit de MES-1 karakterset
    ///     zijn toegestaan.
    /// </summary>
    /// <value>
    ///     De unieke aanduiding van het brondocument op basis waarvan een opname,  mutatie of een verwijdering van gegevens
    ///     ten aanzien van een woonplaats  heeft plaatsgevonden binnen een gemeente.  Alle karakters uit de MES-1 karakterset
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
    ///     Gets or Sets LigtIn
    /// </summary>
    [DataMember(Name = "ligtIn", EmitDefaultValue = false)]
    [JsonPropertyName("ligtIn")]
    public string LigtIn { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenbareRuimte {\n");
        sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
        sb.Append("  Domein: ").Append(Domein).Append("\n");
        sb.Append("  Naam: ").Append(Naam).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  KorteNaam: ").Append(KorteNaam).Append("\n");
        sb.Append("  Geconstateerd: ").Append(Geconstateerd).Append("\n");
        sb.Append("  Documentdatum: ").Append(Documentdatum).Append("\n");
        sb.Append("  Documentnummer: ").Append(Documentnummer).Append("\n");
        sb.Append("  Voorkomen: ").Append(Voorkomen).Append("\n");
        sb.Append("  LigtIn: ").Append(LigtIn).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}