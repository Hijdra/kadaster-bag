using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class OpenbareRuimteEmbedded
{
    /// <summary>
    ///     Gets or Sets LigtInWoonplaats
    /// </summary>
    [DataMember(Name = "ligtInWoonplaats", EmitDefaultValue = false)]
    [JsonPropertyName("ligtInWoonplaats")]
    public WoonplaatsIOHal LigtInWoonplaats { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenbareRuimteEmbedded {\n");
        sb.Append("  LigtInWoonplaats: ").Append(LigtInWoonplaats).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}