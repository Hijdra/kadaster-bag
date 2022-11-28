using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Wanneer hier een property is opgenomen met de waarde true, dan is de aan het adres gerelateerde gelijknamige
///     resource geconstateerd. Geconstateerd is een aanduiding waarmee kan worden aangegeven dat een object in de
///     registratie is opgenomen als gevolg van een feitelijke constatering, zonder dat er op het moment van opname sprake
///     was van een regulier brondocument voor deze opname.
/// </summary>
[DataContract]
public class Geconstateerd
{
    /// <summary>
    ///     Gets or Sets Woonplaats
    /// </summary>
    [DataMember(Name = "woonplaats", EmitDefaultValue = false)]
    [JsonPropertyName("woonplaats")]
    public bool? Woonplaats { get; set; }

    /// <summary>
    ///     Gets or Sets OpenbareRuimte
    /// </summary>
    [DataMember(Name = "openbareRuimte", EmitDefaultValue = false)]
    [JsonPropertyName("openbareRuimte")]
    public bool? OpenbareRuimte { get; set; }

    /// <summary>
    ///     Gets or Sets Nummeraanduiding
    /// </summary>
    [DataMember(Name = "nummeraanduiding", EmitDefaultValue = false)]
    [JsonPropertyName("nummeraanduiding")]
    public bool? Nummeraanduiding { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Geconstateerd {\n");
        sb.Append("  Woonplaats: ").Append(Woonplaats).Append("\n");
        sb.Append("  OpenbareRuimte: ").Append(OpenbareRuimte).Append("\n");
        sb.Append("  Nummeraanduiding: ").Append(Nummeraanduiding).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}