using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class WoonplaatsLinks
{
    /// <summary>
    ///     Gets or Sets Self
    /// </summary>
    [DataMember(Name = "self", EmitDefaultValue = false)]
    [JsonPropertyName("self")]
    public HalLink Self { get; set; }

    /// <summary>
    ///     De gemeente(n) waar de woonplaats onderdeel van uitmaakt.
    /// </summary>
    /// <value>De gemeente(n) waar de woonplaats onderdeel van uitmaakt.</value>
    [DataMember(Name = "bronhouders", EmitDefaultValue = false)]
    [JsonPropertyName("bronhouders")]
    public List<HalLink> Bronhouders { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WoonplaatsLinks {\n");
        sb.Append("  Self: ").Append(Self).Append("\n");
        sb.Append("  Bronhouders: ").Append(Bronhouders).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}