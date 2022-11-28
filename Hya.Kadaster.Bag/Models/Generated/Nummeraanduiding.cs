using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een Nummeraanduiding is een door het bevoegde gemeentelijke orgaan als zodanig toegekende aanduiding van een
///     verblijfsobject, een standplaats of een ligplaats.
/// </summary>
[DataContract]
public class Nummeraanduiding
{
    /// <summary>
    ///     Gets or Sets Identificatie
    /// </summary>
    [DataMember(Name = "identificatie", EmitDefaultValue = false)]
    [JsonPropertyName("identificatie")]
    public string Identificatie { get; set; }

    /// <summary>
    ///     NL.IMBAG.Nummeraanduiding
    /// </summary>
    /// <value>NL.IMBAG.Nummeraanduiding</value>
    [DataMember(Name = "domein", EmitDefaultValue = false)]
    [JsonPropertyName("domein")]
    public string Domein { get; set; }

    /// <summary>
    ///     Een door of namens het gemeentebestuur ten aanzien van een adresseerbaar object toegekende nummering.
    /// </summary>
    /// <value>Een door of namens het gemeentebestuur ten aanzien van een adresseerbaar object toegekende nummering.</value>
    [DataMember(Name = "huisnummer", EmitDefaultValue = false)]
    [JsonPropertyName("huisnummer")]
    public int? Huisnummer { get; set; }

    /// <summary>
    ///     Een door of namens het gemeentebestuur ten aanzien van een adresseerbaar object toegekende toevoeging aan een
    ///     huisnummer in de vorm van een alfanumeriek teken.
    /// </summary>
    /// <value>
    ///     Een door of namens het gemeentebestuur ten aanzien van een adresseerbaar object toegekende toevoeging aan een
    ///     huisnummer in de vorm van een alfanumeriek teken.
    /// </value>
    [DataMember(Name = "huisletter", EmitDefaultValue = false)]
    [JsonPropertyName("huisletter")]
    public string Huisletter { get; set; }

    /// <summary>
    ///     Een door of namens het gemeentebestuur ten aanzien van een adresseerbaar object toegekende nadere toevoeging aan
    ///     een huisnummer of een combinatie van huisnummer en huisletter.
    /// </summary>
    /// <value>
    ///     Een door of namens het gemeentebestuur ten aanzien van een adresseerbaar object toegekende nadere toevoeging aan
    ///     een huisnummer of een combinatie van huisnummer en huisletter.
    /// </value>
    [DataMember(Name = "huisnummertoevoeging", EmitDefaultValue = false)]
    [JsonPropertyName("huisnummertoevoeging")]
    public string Huisnummertoevoeging { get; set; }

    /// <summary>
    ///     De door PostNL vastgestelde code behorende bij een bepaalde combinatie van een straatnaam en een huisnummer.
    /// </summary>
    /// <value>De door PostNL vastgestelde code behorende bij een bepaalde combinatie van een straatnaam en een huisnummer.</value>
    [DataMember(Name = "postcode", EmitDefaultValue = false)]
    [JsonPropertyName("postcode")]
    public string Postcode { get; set; }

    /// <summary>
    ///     Gets or Sets TypeAdresseerbaarObject
    /// </summary>
    [DataMember(Name = "typeAdresseerbaarObject", EmitDefaultValue = false)]
    [JsonPropertyName("typeAdresseerbaarObject")]
    public TypeAdresseerbaarObject TypeAdresseerbaarObject { get; set; }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonPropertyName("status")]
    public StatusNaamgeving Status { get; set; }

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
    ///     aanzien van een woonplaats heeft plaatsgevonden binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn
    ///     toegestaan.
    /// </summary>
    /// <value>
    ///     De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens
    ///     ten aanzien van een woonplaats heeft plaatsgevonden binnen een gemeente. Alle karakters uit de MES-1 karakterset
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
    ///     Gets or Sets LigtAan
    /// </summary>
    [DataMember(Name = "ligtAan", EmitDefaultValue = false)]
    [JsonPropertyName("ligtAan")]
    public string LigtAan { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Nummeraanduiding {\n");
        sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
        sb.Append("  Domein: ").Append(Domein).Append("\n");
        sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
        sb.Append("  Huisletter: ").Append(Huisletter).Append("\n");
        sb.Append("  Huisnummertoevoeging: ").Append(Huisnummertoevoeging).Append("\n");
        sb.Append("  Postcode: ").Append(Postcode).Append("\n");
        sb.Append("  TypeAdresseerbaarObject: ").Append(TypeAdresseerbaarObject).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Geconstateerd: ").Append(Geconstateerd).Append("\n");
        sb.Append("  Documentdatum: ").Append(Documentdatum).Append("\n");
        sb.Append("  Documentnummer: ").Append(Documentnummer).Append("\n");
        sb.Append("  Voorkomen: ").Append(Voorkomen).Append("\n");
        sb.Append("  LigtIn: ").Append(LigtIn).Append("\n");
        sb.Append("  LigtAan: ").Append(LigtAan).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}