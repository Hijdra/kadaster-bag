using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Wanneer hier een property is opgenomen met de waarde true, dan is de waarde van het gelijknamige property in de
///     resource in onderzoek. De juistheid van dit gegeven wordt op dit moment onderzocht. Onder property toelichting
///     wordt toegelicht wat er mogelijk onjuist is aan het betreffende gegeven.
/// </summary>
[DataContract]
public class AdresInOnderzoek
{
    /// <summary>
    ///     Gets or Sets OpenbareRuimteNaam
    /// </summary>
    [DataMember(Name = "openbareRuimteNaam", EmitDefaultValue = false)]
    [JsonPropertyName("openbareRuimteNaam")]
    public bool? OpenbareRuimteNaam { get; set; }

    /// <summary>
    ///     Gets or Sets KorteNaam
    /// </summary>
    [DataMember(Name = "korteNaam", EmitDefaultValue = false)]
    [JsonPropertyName("korteNaam")]
    public bool? KorteNaam { get; set; }

    /// <summary>
    ///     Gets or Sets Huisnummer
    /// </summary>
    [DataMember(Name = "huisnummer", EmitDefaultValue = false)]
    [JsonPropertyName("huisnummer")]
    public bool? Huisnummer { get; set; }

    /// <summary>
    ///     Gets or Sets Huisletter
    /// </summary>
    [DataMember(Name = "huisletter", EmitDefaultValue = false)]
    [JsonPropertyName("huisletter")]
    public bool? Huisletter { get; set; }

    /// <summary>
    ///     Gets or Sets Huisnummertoevoeging
    /// </summary>
    [DataMember(Name = "huisnummertoevoeging", EmitDefaultValue = false)]
    [JsonPropertyName("huisnummertoevoeging")]
    public bool? Huisnummertoevoeging { get; set; }

    /// <summary>
    ///     Gets or Sets Postcode
    /// </summary>
    [DataMember(Name = "postcode", EmitDefaultValue = false)]
    [JsonPropertyName("postcode")]
    public bool? Postcode { get; set; }

    /// <summary>
    ///     Gets or Sets WoonplaatsNaam
    /// </summary>
    [DataMember(Name = "woonplaatsNaam", EmitDefaultValue = false)]
    [JsonPropertyName("woonplaatsNaam")]
    public bool? WoonplaatsNaam { get; set; }

    /// <summary>
    ///     \"Als de nummeraanduidingLigtIn false is (deze is niet in onderzoek) en de openbareRuimteLigtIn is true (deze is
    ///     wel in onderzoek) maar is gerelateerd aan een andere woonplaats dan de nummeraanduiding,  dan wordt de boolean hier
    ///     niet gezet. Deze is dan niet relevant omdat dan de woonplaats wordt gebruikt die gerelateerd is aan de
    ///     nummeraanduiding.\"
    /// </summary>
    /// <value>
    ///     \"Als de nummeraanduidingLigtIn false is (deze is niet in onderzoek) en de openbareRuimteLigtIn is true (deze is
    ///     wel in onderzoek) maar is gerelateerd aan een andere woonplaats dan de nummeraanduiding,  dan wordt de boolean hier
    ///     niet gezet. Deze is dan niet relevant omdat dan de woonplaats wordt gebruikt die gerelateerd is aan de
    ///     nummeraanduiding.\"
    /// </value>
    [DataMember(Name = "openbareRuimteLigtIn", EmitDefaultValue = false)]
    [JsonPropertyName("openbareRuimteLigtIn")]
    public bool? OpenbareRuimteLigtIn { get; set; }

    /// <summary>
    ///     Gets or Sets OpenbareRuimteStatus
    /// </summary>
    [DataMember(Name = "openbareRuimteStatus", EmitDefaultValue = false)]
    [JsonPropertyName("openbareRuimteStatus")]
    public bool? OpenbareRuimteStatus { get; set; }

    /// <summary>
    ///     Gets or Sets NummeraanduidingLigtIn
    /// </summary>
    [DataMember(Name = "nummeraanduidingLigtIn", EmitDefaultValue = false)]
    [JsonPropertyName("nummeraanduidingLigtIn")]
    public bool? NummeraanduidingLigtIn { get; set; }

    /// <summary>
    ///     Gets or Sets NummeraanduidingligtAan
    /// </summary>
    [DataMember(Name = "nummeraanduidingligtAan", EmitDefaultValue = false)]
    [JsonPropertyName("nummeraanduidingligtAan")]
    public bool? NummeraanduidingligtAan { get; set; }

    /// <summary>
    ///     Gets or Sets NummeraanduidingStatus
    /// </summary>
    [DataMember(Name = "nummeraanduidingStatus", EmitDefaultValue = false)]
    [JsonPropertyName("nummeraanduidingStatus")]
    public bool? NummeraanduidingStatus { get; set; }

    /// <summary>
    ///     Gets or Sets Toelichting
    /// </summary>
    [DataMember(Name = "toelichting", EmitDefaultValue = false)]
    [JsonPropertyName("toelichting")]
    public List<string> Toelichting { get; set; }

    /// <summary>
    ///     Gets or Sets Adresregel5
    /// </summary>
    [DataMember(Name = "adresregel5", EmitDefaultValue = false)]
    [JsonPropertyName("adresregel5")]
    public bool? Adresregel5 { get; set; }

    /// <summary>
    ///     Gets or Sets Adresregel6
    /// </summary>
    [DataMember(Name = "adresregel6", EmitDefaultValue = false)]
    [JsonPropertyName("adresregel6")]
    public bool? Adresregel6 { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresInOnderzoek {\n");
        sb.Append("  OpenbareRuimteNaam: ").Append(OpenbareRuimteNaam).Append("\n");
        sb.Append("  KorteNaam: ").Append(KorteNaam).Append("\n");
        sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
        sb.Append("  Huisletter: ").Append(Huisletter).Append("\n");
        sb.Append("  Huisnummertoevoeging: ").Append(Huisnummertoevoeging).Append("\n");
        sb.Append("  Postcode: ").Append(Postcode).Append("\n");
        sb.Append("  WoonplaatsNaam: ").Append(WoonplaatsNaam).Append("\n");
        sb.Append("  OpenbareRuimteLigtIn: ").Append(OpenbareRuimteLigtIn).Append("\n");
        sb.Append("  OpenbareRuimteStatus: ").Append(OpenbareRuimteStatus).Append("\n");
        sb.Append("  NummeraanduidingLigtIn: ").Append(NummeraanduidingLigtIn).Append("\n");
        sb.Append("  NummeraanduidingligtAan: ").Append(NummeraanduidingligtAan).Append("\n");
        sb.Append("  NummeraanduidingStatus: ").Append(NummeraanduidingStatus).Append("\n");
        sb.Append("  Toelichting: ").Append(Toelichting).Append("\n");
        sb.Append("  Adresregel5: ").Append(Adresregel5).Append("\n");
        sb.Append("  Adresregel6: ").Append(Adresregel6).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}