using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class AdresIOEmbedded
{
    /// <summary>
    ///     Gets or Sets OpenbareRuimte
    /// </summary>
    [DataMember(Name = "openbareRuimte", EmitDefaultValue = false)]
    [JsonPropertyName("openbareRuimte")]
    public OpenbareRuimteIOHal OpenbareRuimte { get; set; }

    /// <summary>
    ///     Gets or Sets Nummeraanduiding
    /// </summary>
    [DataMember(Name = "nummeraanduiding", EmitDefaultValue = false)]
    [JsonPropertyName("nummeraanduiding")]
    public NummeraanduidingIOHal Nummeraanduiding { get; set; }

    /// <summary>
    ///     Gets or Sets Woonplaats
    /// </summary>
    [DataMember(Name = "woonplaats", EmitDefaultValue = false)]
    [JsonPropertyName("woonplaats")]
    public WoonplaatsIOHal Woonplaats { get; set; }

    /// <summary>
    ///     Gets or Sets AdresseerbaarObject
    /// </summary>
    [DataMember(Name = "adresseerbaarObject", EmitDefaultValue = false)]
    [JsonPropertyName("adresseerbaarObject")]
    public AdresseerbaarObjectIOHal AdresseerbaarObject { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresIOEmbedded {\n");
        sb.Append("  OpenbareRuimte: ").Append(OpenbareRuimte).Append("\n");
        sb.Append("  Nummeraanduiding: ").Append(Nummeraanduiding).Append("\n");
        sb.Append("  Woonplaats: ").Append(Woonplaats).Append("\n");
        sb.Append("  AdresseerbaarObject: ").Append(AdresseerbaarObject).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}