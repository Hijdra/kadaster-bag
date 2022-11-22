using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class WoonplaatsEmbedded
{
    /// <summary>
    ///     Gets or Sets Geometrie
    /// </summary>
    [DataMember(Name = "geometrie", EmitDefaultValue = false)]
    [JsonPropertyName("geometrie")]
    public VlakOfMultivlak Geometrie { get; set; }

    /// <summary>
    ///     Gets or Sets Bronhouders
    /// </summary>
    [DataMember(Name = "bronhouders", EmitDefaultValue = false)]
    [JsonPropertyName("bronhouders")]
    public List<Gemeente> Bronhouders { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WoonplaatsEmbedded {\n");
        sb.Append("  Geometrie: ").Append(Geometrie).Append("\n");
        sb.Append("  Bronhouders: ").Append(Bronhouders).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}