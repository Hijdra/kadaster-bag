using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class AdresIOLinks
{
    /// <summary>
    ///     Gets or Sets Self
    /// </summary>
    [DataMember(Name = "self", EmitDefaultValue = false)]
    [JsonPropertyName("self")]
    public HalLink Self { get; set; }

    /// <summary>
    ///     Gets or Sets OpenbareRuimte
    /// </summary>
    [DataMember(Name = "openbareRuimte", EmitDefaultValue = false)]
    [JsonPropertyName("openbareRuimte")]
    public HalLink OpenbareRuimte { get; set; }

    /// <summary>
    ///     Gets or Sets Nummeraanduiding
    /// </summary>
    [DataMember(Name = "nummeraanduiding", EmitDefaultValue = false)]
    [JsonPropertyName("nummeraanduiding")]
    public HalLink Nummeraanduiding { get; set; }

    /// <summary>
    ///     Gets or Sets Woonplaats
    /// </summary>
    [DataMember(Name = "woonplaats", EmitDefaultValue = false)]
    [JsonPropertyName("woonplaats")]
    public HalLink Woonplaats { get; set; }

    /// <summary>
    ///     Gets or Sets AdresseerbaarObject
    /// </summary>
    [DataMember(Name = "adresseerbaarObject", EmitDefaultValue = false)]
    [JsonPropertyName("adresseerbaarObject")]
    public HalLink AdresseerbaarObject { get; set; }

    /// <summary>
    ///     Het/de aan het adres gerelateerde pand(en).
    /// </summary>
    /// <value>Het/de aan het adres gerelateerde pand(en).</value>
    [DataMember(Name = "panden", EmitDefaultValue = false)]
    [JsonPropertyName("panden")]
    public List<HalLink> Panden { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresIOLinks {\n");
        sb.Append("  Self: ").Append(Self).Append("\n");
        sb.Append("  OpenbareRuimte: ").Append(OpenbareRuimte).Append("\n");
        sb.Append("  Nummeraanduiding: ").Append(Nummeraanduiding).Append("\n");
        sb.Append("  Woonplaats: ").Append(Woonplaats).Append("\n");
        sb.Append("  AdresseerbaarObject: ").Append(AdresseerbaarObject).Append("\n");
        sb.Append("  Panden: ").Append(Panden).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}