using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class WoonplaatsIOHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Woonplaatsen
    /// </summary>
    [DataMember(Name = "woonplaatsen", EmitDefaultValue = false)]
    [JsonPropertyName("woonplaatsen")]
    public List<WoonplaatsIOHal> Woonplaatsen { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WoonplaatsIOHalCollectionEmbedded {\n");
        sb.Append("  Woonplaatsen: ").Append(Woonplaatsen).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}