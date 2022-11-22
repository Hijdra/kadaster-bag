using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Bij het controleren of een property in onderzoek is kan het zijn  dat er meerdere indicaties voor een property
///     opgenomen zijn.  In dat geval zijn er meerdere indicaties waarvan de naam begint  met de property-naam.
/// </summary>
[DataContract]
public class AdresUitgebreidInOnderzoek : AdresInOnderzoek
{
    /// <summary>
    ///     Gets or Sets TypeAdresseerbaarObject
    /// </summary>
    [DataMember(Name = "typeAdresseerbaarObject", EmitDefaultValue = false)]
    [JsonPropertyName("typeAdresseerbaarObject")]
    public bool? TypeAdresseerbaarObject { get; set; }

    /// <summary>
    ///     Een indicatie dat de geometrie van het aan een adres gerelateerde  adresseerbare object in onderzoek is.
    /// </summary>
    /// <value>Een indicatie dat de geometrie van het aan een adres gerelateerde  adresseerbare object in onderzoek is. </value>
    [DataMember(Name = "adresseerbaarObjectGeometrie", EmitDefaultValue = false)]
    [JsonPropertyName("adresseerbaarObjectGeometrie")]
    public bool? AdresseerbaarObjectGeometrie { get; set; }

    /// <summary>
    ///     Een indicatie dat de status van het aan een adres gerelateerde  adresseerbare object in onderzoek is.
    /// </summary>
    /// <value>Een indicatie dat de status van het aan een adres gerelateerde  adresseerbare object in onderzoek is. </value>
    [DataMember(Name = "adresseerbaarObjectStatus", EmitDefaultValue = false)]
    [JsonPropertyName("adresseerbaarObjectStatus")]
    public bool? AdresseerbaarObjectStatus { get; set; }

    /// <summary>
    ///     Gets or Sets AdresseerbaarObjectheeftAlsHoofdadres
    /// </summary>
    [DataMember(Name = "adresseerbaarObjectheeftAlsHoofdadres", EmitDefaultValue = false)]
    [JsonPropertyName("adresseerbaarObjectheeftAlsHoofdadres")]
    public bool? AdresseerbaarObjectheeftAlsHoofdadres { get; set; }

    /// <summary>
    ///     Gets or Sets AdresseerbaarObjectheeftAlsNevenadres
    /// </summary>
    [DataMember(Name = "adresseerbaarObjectheeftAlsNevenadres", EmitDefaultValue = false)]
    [JsonPropertyName("adresseerbaarObjectheeftAlsNevenadres")]
    public bool? AdresseerbaarObjectheeftAlsNevenadres { get; set; }

    /// <summary>
    ///     Gets or Sets Gebruiksdoelen
    /// </summary>
    [DataMember(Name = "gebruiksdoelen", EmitDefaultValue = false)]
    [JsonPropertyName("gebruiksdoelen")]
    public bool? Gebruiksdoelen { get; set; }

    /// <summary>
    ///     Gets or Sets Oppervlakte
    /// </summary>
    [DataMember(Name = "oppervlakte", EmitDefaultValue = false)]
    [JsonPropertyName("oppervlakte")]
    public bool? Oppervlakte { get; set; }

    /// <summary>
    ///     Gets or Sets MaaktDeelUitVan
    /// </summary>
    [DataMember(Name = "maaktDeelUitVan", EmitDefaultValue = false)]
    [JsonPropertyName("maaktDeelUitVan")]
    public bool? MaaktDeelUitVan { get; set; }

    /// <summary>
    ///     Gets or Sets OorspronkelijkBouwjaar
    /// </summary>
    [DataMember(Name = "oorspronkelijkBouwjaar", EmitDefaultValue = false)]
    [JsonPropertyName("oorspronkelijkBouwjaar")]
    public bool? OorspronkelijkBouwjaar { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresUitgebreidInOnderzoek {\n");
        sb.Append("  TypeAdresseerbaarObject: ").Append(TypeAdresseerbaarObject).Append("\n");
        sb.Append("  AdresseerbaarObjectGeometrie: ").Append(AdresseerbaarObjectGeometrie).Append("\n");
        sb.Append("  AdresseerbaarObjectStatus: ").Append(AdresseerbaarObjectStatus).Append("\n");
        sb.Append("  AdresseerbaarObjectheeftAlsHoofdadres: ").Append(AdresseerbaarObjectheeftAlsHoofdadres)
            .Append("\n");
        sb.Append("  AdresseerbaarObjectheeftAlsNevenadres: ").Append(AdresseerbaarObjectheeftAlsNevenadres)
            .Append("\n");
        sb.Append("  Gebruiksdoelen: ").Append(Gebruiksdoelen).Append("\n");
        sb.Append("  Oppervlakte: ").Append(Oppervlakte).Append("\n");
        sb.Append("  MaaktDeelUitVan: ").Append(MaaktDeelUitVan).Append("\n");
        sb.Append("  OorspronkelijkBouwjaar: ").Append(OorspronkelijkBouwjaar).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}