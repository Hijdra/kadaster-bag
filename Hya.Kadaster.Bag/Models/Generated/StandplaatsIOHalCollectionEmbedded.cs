using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class StandplaatsIOHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Standplaatsen
    /// </summary>
    [DataMember(Name = "standplaatsen", EmitDefaultValue = false)]
    [JsonPropertyName("standplaatsen")]
    public List<StandplaatsIOHal> Standplaatsen { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class StandplaatsIOHalCollectionEmbedded {\n");
        sb.Append("  Standplaatsen: ").Append(Standplaatsen).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}