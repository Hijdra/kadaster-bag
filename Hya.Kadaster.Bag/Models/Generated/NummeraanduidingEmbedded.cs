using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class NummeraanduidingEmbedded
{
    /// <summary>
    ///     Gets or Sets LigtInWoonplaats
    /// </summary>
    [DataMember(Name = "ligtInWoonplaats", EmitDefaultValue = false)]
    [JsonPropertyName("ligtInWoonplaats")]
    public WoonplaatsIOHal LigtInWoonplaats { get; set; }

    /// <summary>
    ///     Gets or Sets LigtAanOpenbareRuimte
    /// </summary>
    [DataMember(Name = "ligtAanOpenbareRuimte", EmitDefaultValue = false)]
    [JsonPropertyName("ligtAanOpenbareRuimte")]
    public OpenbareRuimteIOHal LigtAanOpenbareRuimte { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NummeraanduidingEmbedded {\n");
        sb.Append("  LigtInWoonplaats: ").Append(LigtInWoonplaats).Append("\n");
        sb.Append("  LigtAanOpenbareRuimte: ").Append(LigtAanOpenbareRuimte).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}