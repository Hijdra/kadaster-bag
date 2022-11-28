using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class AdresUitgebreidGeconstateerd : Geconstateerd
{
    /// <summary>
    ///     Gets or Sets Ligplaats
    /// </summary>
    [DataMember(Name = "ligplaats", EmitDefaultValue = false)]
    [JsonPropertyName("ligplaats")]
    public bool? Ligplaats { get; set; }

    /// <summary>
    ///     Gets or Sets Standplaats
    /// </summary>
    [DataMember(Name = "standplaats", EmitDefaultValue = false)]
    [JsonPropertyName("standplaats")]
    public bool? Standplaats { get; set; }

    /// <summary>
    ///     Gets or Sets Verblijfsobject
    /// </summary>
    [DataMember(Name = "verblijfsobject", EmitDefaultValue = false)]
    [JsonPropertyName("verblijfsobject")]
    public bool? Verblijfsobject { get; set; }

    /// <summary>
    ///     Gets or Sets Pand
    /// </summary>
    [DataMember(Name = "pand", EmitDefaultValue = false)]
    [JsonPropertyName("pand")]
    public bool? Pand { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresUitgebreidGeconstateerd {\n");
        sb.Append("  Ligplaats: ").Append(Ligplaats).Append("\n");
        sb.Append("  Standplaats: ").Append(Standplaats).Append("\n");
        sb.Append("  Verblijfsobject: ").Append(Verblijfsobject).Append("\n");
        sb.Append("  Pand: ").Append(Pand).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}