using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class OpenbareRuimteIOHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets Openbareruimten
    /// </summary>
    [DataMember(Name = "openbareruimten", EmitDefaultValue = false)]
    [JsonPropertyName("openbareruimten")]
    public List<OpenbareRuimteIOHal> Openbareruimten { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenbareRuimteIOHalCollectionEmbedded {\n");
        sb.Append("  Openbareruimten: ").Append(Openbareruimten).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}