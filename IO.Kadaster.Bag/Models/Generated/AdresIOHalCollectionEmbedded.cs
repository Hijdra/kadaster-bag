using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class AdresIOHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Adressen
    /// </summary>
    [DataMember(Name = "adressen", EmitDefaultValue = false)]
    [JsonPropertyName("adressen")]
    public List<AdresIOHal> Adressen { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresIOHalCollectionEmbedded {\n");
        sb.Append("  Adressen: ").Append(Adressen).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}