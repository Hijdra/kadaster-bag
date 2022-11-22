using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class PandIOLvcHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Voorkomens
    /// </summary>
    [DataMember(Name = "voorkomens", EmitDefaultValue = false)]
    [JsonPropertyName("voorkomens")]
    public List<PandIOHal> Voorkomens { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PandIOLvcHalCollectionEmbedded {\n");
        sb.Append("  Voorkomens: ").Append(Voorkomens).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}