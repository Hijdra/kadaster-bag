using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class NummeraanduidingIOHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Nummeraanduidingen
    /// </summary>
    [DataMember(Name = "nummeraanduidingen", EmitDefaultValue = false)]
    [JsonPropertyName("nummeraanduidingen")]
    public List<NummeraanduidingIOHal> Nummeraanduidingen { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NummeraanduidingIOHalCollectionEmbedded {\n");
        sb.Append("  Nummeraanduidingen: ").Append(Nummeraanduidingen).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}