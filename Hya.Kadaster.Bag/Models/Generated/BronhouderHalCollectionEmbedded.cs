using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class BronhouderHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Bronhouders
    /// </summary>
    [DataMember(Name = "bronhouders", EmitDefaultValue = false)]
    [JsonPropertyName("bronhouders")]
    public List<BronhouderHal> Bronhouders { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BronhouderHalCollectionEmbedded {\n");
        sb.Append("  Bronhouders: ").Append(Bronhouders).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}