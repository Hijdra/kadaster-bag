using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Door het bevoegde gemeentelijke orgaan aan een verblijfsobject, een  standplaats of een ligplaats toegekende
///     benaming, bestaande uit een  combinatie van de naam van een openbare ruimte, het huisnummer, een  eventuele
///     huisletter en huisnummertoevoeging van de nummeraanduiding  en de naam van de woonplaats.
/// </summary>
[DataContract]
public class Adres
{
    /// <summary>
    ///     Een naam die aan een openbare ruimte is toegekend in een daartoe  strekkend formeel gemeentelijk besluit. Het
    ///     betreft hier de straatnaam.
    /// </summary>
    /// <value>
    ///     Een naam die aan een openbare ruimte is toegekend in een daartoe  strekkend formeel gemeentelijk besluit. Het
    ///     betreft hier de straatnaam.
    /// </value>
    [DataMember(Name = "openbareRuimteNaam", EmitDefaultValue = false)]
    [JsonPropertyName("openbareRuimteNaam")]
    public string OpenbareRuimteNaam { get; set; }

    /// <summary>
    ///     De officiële openbare ruimte naam als deze niet langer is dan 24 tekens of de volgens de NEN5825 verkorte naam van
    ///     maximaal 24 tekens.
    /// </summary>
    /// <value>
    ///     De officiële openbare ruimte naam als deze niet langer is dan 24 tekens of de volgens de NEN5825 verkorte naam
    ///     van maximaal 24 tekens.
    /// </value>
    [DataMember(Name = "korteNaam", EmitDefaultValue = false)]
    [JsonPropertyName("korteNaam")]
    public string KorteNaam { get; set; }

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
    ///     De benaming van een door het gemeentebestuur aangewezen woonplaats.
    /// </summary>
    /// <value>De benaming van een door het gemeentebestuur aangewezen woonplaats.</value>
    [DataMember(Name = "woonplaatsNaam", EmitDefaultValue = false)]
    [JsonPropertyName("woonplaatsNaam")]
    public string WoonplaatsNaam { get; set; }

    /// <summary>
    ///     Gets or Sets NummeraanduidingIdentificatie
    /// </summary>
    [DataMember(Name = "nummeraanduidingIdentificatie", EmitDefaultValue = false)]
    [JsonPropertyName("nummeraanduidingIdentificatie")]
    public string NummeraanduidingIdentificatie { get; set; }

    /// <summary>
    ///     Gets or Sets OpenbareRuimteIdentificatie
    /// </summary>
    [DataMember(Name = "openbareRuimteIdentificatie", EmitDefaultValue = false)]
    [JsonPropertyName("openbareRuimteIdentificatie")]
    public string OpenbareRuimteIdentificatie { get; set; }

    /// <summary>
    ///     Gets or Sets WoonplaatsIdentificatie
    /// </summary>
    [DataMember(Name = "woonplaatsIdentificatie", EmitDefaultValue = false)]
    [JsonPropertyName("woonplaatsIdentificatie")]
    public string WoonplaatsIdentificatie { get; set; }

    /// <summary>
    ///     Gets or Sets AdresseerbaarObjectIdentificatie
    /// </summary>
    [DataMember(Name = "adresseerbaarObjectIdentificatie", EmitDefaultValue = false)]
    [JsonPropertyName("adresseerbaarObjectIdentificatie")]
    public string AdresseerbaarObjectIdentificatie { get; set; }

    /// <summary>
    ///     Identificatie(s) van het pand of de panden waar het verblijfsobject deel van uit maakt.
    /// </summary>
    /// <value>Identificatie(s) van het pand of de panden waar het verblijfsobject deel van uit maakt.</value>
    [DataMember(Name = "pandIdentificaties", EmitDefaultValue = false)]
    [JsonPropertyName("pandIdentificaties")]
    public List<string> PandIdentificaties { get; set; }

    /// <summary>
    ///     Indicatie dat dit adres een nevenadres is van een adresseerbaar object. Het adres is een hoofdadres als deze
    ///     indicatie niet wordt meegeleverd.
    /// </summary>
    /// <value>
    ///     Indicatie dat dit adres een nevenadres is van een adresseerbaar object. Het adres is een hoofdadres als deze
    ///     indicatie niet wordt meegeleverd.
    /// </value>
    [DataMember(Name = "indicatieNevenadres", EmitDefaultValue = false)]
    [JsonPropertyName("indicatieNevenadres")]
    public bool? IndicatieNevenadres { get; set; }

    /// <summary>
    ///     Adresregel 5 zoals beschreven in NEN 5825:2002 paragraaf 7.2. Bevat:  - straatnaam en indien aanwezig huisnummer en
    ///     huisnummertoevoeging,    waarbij huisnummertoevoeging een huisletter, huisnummertoevoeging of een combinatie van
    ///     beide kan bevatten of - straatnaam en woonboot- of woonwagenverwijziging of - de aanduiding \"Postbus\" en het
    ///     postbusnummer of - de aanduiding \"Antwoordnummer\" en het antwoordnummer of - de aanduiding \"PostApart\" en het
    ///     PostApartnummer
    /// </summary>
    /// <value>
    ///     Adresregel 5 zoals beschreven in NEN 5825:2002 paragraaf 7.2. Bevat:  - straatnaam en indien aanwezig huisnummer
    ///     en huisnummertoevoeging,    waarbij huisnummertoevoeging een huisletter, huisnummertoevoeging of een combinatie van
    ///     beide kan bevatten of - straatnaam en woonboot- of woonwagenverwijziging of - de aanduiding \"Postbus\" en het
    ///     postbusnummer of - de aanduiding \"Antwoordnummer\" en het antwoordnummer of - de aanduiding \"PostApart\" en het
    ///     PostApartnummer
    /// </value>
    [DataMember(Name = "adresregel5", EmitDefaultValue = false)]
    [JsonPropertyName("adresregel5")]
    public string Adresregel5 { get; set; }

    /// <summary>
    ///     Adresregel 6 zoals beschreven in NEN 5825:2002 paragraaf 7.2. Bevat:   postcode en woonplaats
    /// </summary>
    /// <value>Adresregel 6 zoals beschreven in NEN 5825:2002 paragraaf 7.2. Bevat:   postcode en woonplaats </value>
    [DataMember(Name = "adresregel6", EmitDefaultValue = false)]
    [JsonPropertyName("adresregel6")]
    public string Adresregel6 { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Adres {\n");
        sb.Append("  OpenbareRuimteNaam: ").Append(OpenbareRuimteNaam).Append("\n");
        sb.Append("  KorteNaam: ").Append(KorteNaam).Append("\n");
        sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
        sb.Append("  Huisletter: ").Append(Huisletter).Append("\n");
        sb.Append("  Huisnummertoevoeging: ").Append(Huisnummertoevoeging).Append("\n");
        sb.Append("  Postcode: ").Append(Postcode).Append("\n");
        sb.Append("  WoonplaatsNaam: ").Append(WoonplaatsNaam).Append("\n");
        sb.Append("  NummeraanduidingIdentificatie: ").Append(NummeraanduidingIdentificatie).Append("\n");
        sb.Append("  OpenbareRuimteIdentificatie: ").Append(OpenbareRuimteIdentificatie).Append("\n");
        sb.Append("  WoonplaatsIdentificatie: ").Append(WoonplaatsIdentificatie).Append("\n");
        sb.Append("  AdresseerbaarObjectIdentificatie: ").Append(AdresseerbaarObjectIdentificatie).Append("\n");
        sb.Append("  PandIdentificaties: ").Append(PandIdentificaties).Append("\n");
        sb.Append("  IndicatieNevenadres: ").Append(IndicatieNevenadres).Append("\n");
        sb.Append("  Adresregel5: ").Append(Adresregel5).Append("\n");
        sb.Append("  Adresregel6: ").Append(Adresregel6).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}