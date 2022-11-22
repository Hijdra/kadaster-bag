using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class LigplaatsIOHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Ligplaatsen
    /// </summary>
    [DataMember(Name = "ligplaatsen", EmitDefaultValue = false)]
    [JsonPropertyName("ligplaatsen")]
    public List<LigplaatsIOHal> Ligplaatsen { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LigplaatsIOHalCollectionEmbedded {\n");
        sb.Append("  Ligplaatsen: ").Append(Ligplaatsen).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}