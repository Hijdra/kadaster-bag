using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class AdresUitgebreidHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Adressen
    /// </summary>
    [DataMember(Name = "adressen", EmitDefaultValue = false)]
    [JsonPropertyName("adressen")]
    public List<AdresUitgebreidHal> Adressen { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresUitgebreidHalCollectionEmbedded {\n");
        sb.Append("  Adressen: ").Append(Adressen).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}