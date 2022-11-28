using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     \&quot;Zoek binnen een bereik van de opgegeven minimumwaarde tot maximumwaarde.  De opgegeven minimumwaarde moet
///     lager zijn dan de opgegeven maximumwaarde.\&quot;
/// </summary>
[DataContract]
public class BouwjaarFilter
{
    /// <summary>
    ///     Zoek naar waarden groter of gelijk aan de opgegeven waarde.
    /// </summary>
    /// <value>Zoek naar waarden groter of gelijk aan de opgegeven waarde.</value>
    [DataMember(Name = "min", EmitDefaultValue = false)]
    [JsonPropertyName("min")]
    public int? Min { get; set; }

    /// <summary>
    ///     Zoek naar waarden kleiner dan de opgegeven waarde.
    /// </summary>
    /// <value>Zoek naar waarden kleiner dan de opgegeven waarde.</value>
    [DataMember(Name = "max", EmitDefaultValue = false)]
    [JsonPropertyName("max")]
    public int? Max { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BouwjaarFilter {\n");
        sb.Append("  Min: ").Append(Min).Append("\n");
        sb.Append("  Max: ").Append(Max).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}