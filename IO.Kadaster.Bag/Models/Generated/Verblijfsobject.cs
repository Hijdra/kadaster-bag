using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een Verblijfsobject is de kleinste binnen een of meer panden gelegen en voor woon-, bedrijfsmatige, of recreatieve
///     doeleinden geschikte eenheid van gebruik die ontsloten wordt via een eigen afsluitbare toegang vanaf de openbare
///     weg, een erf of een gedeelde verkeersruimte, onderwerp kan zijn van goederenrechtelijke rechtshandelingen en in
///     functioneel opzicht zelfstandig is.
/// </summary>
[DataContract]
public class Verblijfsobject : AdresseerbaarObject
{
    /// <summary>
    ///     Gets or Sets Identificatie
    /// </summary>
    [DataMember(Name = "identificatie", EmitDefaultValue = false)]
    [JsonPropertyName("identificatie")]
    public string Identificatie { get; set; }

    /// <summary>
    ///     NL.IMBAG.Verblijfsobject
    /// </summary>
    /// <value>NL.IMBAG.Verblijfsobject</value>
    [DataMember(Name = "domein", EmitDefaultValue = false)]
    [JsonPropertyName("domein")]
    public string Domein { get; set; }

    /// <summary>
    ///     Gets or Sets Geometrie
    /// </summary>
    [DataMember(Name = "geometrie", EmitDefaultValue = false)]
    [JsonPropertyName("geometrie")]
    public PuntOfVlak Geometrie { get; set; }

    /// <summary>
    ///     Gets or Sets Gebruiksdoelen
    /// </summary>
    [DataMember(Name = "gebruiksdoelen", EmitDefaultValue = false)]
    [JsonPropertyName("gebruiksdoelen")]
    public List<Gebruiksdoel> Gebruiksdoelen { get; set; }

    /// <summary>
    ///     Gets or Sets Oppervlakte
    /// </summary>
    [DataMember(Name = "oppervlakte", EmitDefaultValue = false)]
    [JsonPropertyName("oppervlakte")]
    public int? Oppervlakte { get; set; }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonPropertyName("status")]
    public StatusVerblijfsobject Status { get; set; }

    /// <summary>
    ///     Gets or Sets Geconstateerd
    /// </summary>
    [DataMember(Name = "geconstateerd", EmitDefaultValue = false)]
    [JsonPropertyName("geconstateerd")]
    public Indicatie Geconstateerd { get; set; }

    /// <summary>
    ///     De datum waarop het brondocument is vastgesteld, op basis waarvan een opname, mutatie of een verwijdering van
    ///     gegevens ten aanzien van een object heeft plaatsgevonden.
    /// </summary>
    /// <value>
    ///     De datum waarop het brondocument is vastgesteld, op basis waarvan een opname, mutatie of een verwijdering van
    ///     gegevens ten aanzien van een object heeft plaatsgevonden.
    /// </value>
    [DataMember(Name = "documentdatum", EmitDefaultValue = false)]
    [JsonPropertyName("documentdatum")]
    public DateTime? Documentdatum { get; set; }

    /// <summary>
    ///     De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens ten
    ///     aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn
    ///     toegestaan.
    /// </summary>
    /// <value>
    ///     De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens
    ///     ten aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset
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
    ///     Gets or Sets MaaktDeelUitVan
    /// </summary>
    [DataMember(Name = "maaktDeelUitVan", EmitDefaultValue = false)]
    [JsonPropertyName("maaktDeelUitVan")]
    public List<string> MaaktDeelUitVan { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Verblijfsobject {\n");
        sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
        sb.Append("  Domein: ").Append(Domein).Append("\n");
        sb.Append("  Geometrie: ").Append(Geometrie).Append("\n");
        sb.Append("  Gebruiksdoelen: ").Append(Gebruiksdoelen).Append("\n");
        sb.Append("  Oppervlakte: ").Append(Oppervlakte).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Geconstateerd: ").Append(Geconstateerd).Append("\n");
        sb.Append("  Documentdatum: ").Append(Documentdatum).Append("\n");
        sb.Append("  Documentnummer: ").Append(Documentnummer).Append("\n");
        sb.Append("  Voorkomen: ").Append(Voorkomen).Append("\n");
        sb.Append("  MaaktDeelUitVan: ").Append(MaaktDeelUitVan).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}