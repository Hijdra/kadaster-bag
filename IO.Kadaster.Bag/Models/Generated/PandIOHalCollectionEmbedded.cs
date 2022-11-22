using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class PandIOHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Panden
    /// </summary>
    [DataMember(Name = "panden", EmitDefaultValue = false)]
    [JsonPropertyName("panden")]
    public List<PandIOHal> Panden { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PandIOHalCollectionEmbedded {\n");
        sb.Append("  Panden: ").Append(Panden).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}