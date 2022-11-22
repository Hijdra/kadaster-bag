using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Gegevens van een provincie
/// </summary>
[DataContract]
public class Provincie
{
    /// <summary>
    ///     Gets or Sets Identificatie
    /// </summary>
    [DataMember(Name = "identificatie", EmitDefaultValue = false)]
    [JsonPropertyName("identificatie")]
    public int? Identificatie { get; set; }

    /// <summary>
    ///     Gets or Sets Naam
    /// </summary>
    [DataMember(Name = "naam", EmitDefaultValue = false)]
    [JsonPropertyName("naam")]
    public string Naam { get; set; }

    /// <summary>
    ///     Gets or Sets Afkorting
    /// </summary>
    [DataMember(Name = "afkorting", EmitDefaultValue = false)]
    [JsonPropertyName("afkorting")]
    public string Afkorting { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Provincie {\n");
        sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
        sb.Append("  Naam: ").Append(Naam).Append("\n");
        sb.Append("  Afkorting: ").Append(Afkorting).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}