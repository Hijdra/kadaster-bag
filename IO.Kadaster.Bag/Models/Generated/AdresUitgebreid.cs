using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een adres is een verzameling van informatie uit adresseerbare objecten,  gerelateerde nummeraanduidingen (hoofd- en
///     nevenadres(sen)), aan de  nummeraanduiding gerelateerde openbare ruimte en (indien aanwezig) de aan de
///     nummeraanduiding gerelateerde woonplaats en indien deze niet  beschikbaar is, de aan de openbare ruimte
///     gerelateerde woonplaats.  Waarbij alleen &#x27;huidige&#x27; object voorkomen informatie wordt geretourneerd, dit
///     houdt in: het actuele object voorkomen mits deze geen eind status  heeft. Adres uitgebreid bevat een adres
///     uitgebreid met adresseerbaar  object informatie.
/// </summary>
[DataContract]
public class AdresUitgebreid : Adres
{
    /// <summary>
    ///     Gets or Sets TypeAdresseerbaarObject
    /// </summary>
    [DataMember(Name = "typeAdresseerbaarObject", EmitDefaultValue = false)]
    [JsonPropertyName("typeAdresseerbaarObject")]
    public TypeAdresseerbaarObject TypeAdresseerbaarObject { get; set; }

    /// <summary>
    ///     Gets or Sets AdresseerbaarObjectGeometrie
    /// </summary>
    [DataMember(Name = "adresseerbaarObjectGeometrie", EmitDefaultValue = false)]
    [JsonPropertyName("adresseerbaarObjectGeometrie")]
    public PuntOfVlak AdresseerbaarObjectGeometrie { get; set; }

    /// <summary>
    ///     Gets or Sets AdresseerbaarObjectStatus
    /// </summary>
    [DataMember(Name = "adresseerbaarObjectStatus", EmitDefaultValue = false)]
    [JsonPropertyName("adresseerbaarObjectStatus")]
    public string AdresseerbaarObjectStatus { get; set; }

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
    ///     Gets or Sets OorspronkelijkBouwjaar
    /// </summary>
    [DataMember(Name = "oorspronkelijkBouwjaar", EmitDefaultValue = false)]
    [JsonPropertyName("oorspronkelijkBouwjaar")]
    public List<string> OorspronkelijkBouwjaar { get; set; }

    /// <summary>
    ///     Gets or Sets PandStatussen
    /// </summary>
    [DataMember(Name = "pandStatussen", EmitDefaultValue = false)]
    [JsonPropertyName("pandStatussen")]
    public List<StatusPand> PandStatussen { get; set; }

    /// <summary>
    ///     Gets or Sets Geconstateerd
    /// </summary>
    [DataMember(Name = "geconstateerd", EmitDefaultValue = false)]
    [JsonPropertyName("geconstateerd")]
    public AdresUitgebreidGeconstateerd Geconstateerd { get; set; }

    /// <summary>
    ///     Gets or Sets Inonderzoek
    /// </summary>
    [DataMember(Name = "inonderzoek", EmitDefaultValue = false)]
    [JsonPropertyName("inonderzoek")]
    public AdresUitgebreidInOnderzoek Inonderzoek { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresUitgebreid {\n");
        sb.Append("  TypeAdresseerbaarObject: ").Append(TypeAdresseerbaarObject).Append("\n");
        sb.Append("  AdresseerbaarObjectGeometrie: ").Append(AdresseerbaarObjectGeometrie).Append("\n");
        sb.Append("  AdresseerbaarObjectStatus: ").Append(AdresseerbaarObjectStatus).Append("\n");
        sb.Append("  Gebruiksdoelen: ").Append(Gebruiksdoelen).Append("\n");
        sb.Append("  Oppervlakte: ").Append(Oppervlakte).Append("\n");
        sb.Append("  OorspronkelijkBouwjaar: ").Append(OorspronkelijkBouwjaar).Append("\n");
        sb.Append("  PandStatussen: ").Append(PandStatussen).Append("\n");
        sb.Append("  Geconstateerd: ").Append(Geconstateerd).Append("\n");
        sb.Append("  Inonderzoek: ").Append(Inonderzoek).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}