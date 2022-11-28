using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een samengesteld geometriegegevenstype waarbij wordt afgedwongen dat voor de geometrie een  keuze gemaakt moet
///     worden tussen een vlak (GM_Surface) of een multivlak (GM_MultiSurface).
/// </summary>
[DataContract]
public class VlakOfMultivlak
{
    /// <summary>
    ///     Gets or Sets Vlak
    /// </summary>
    [DataMember(Name = "vlak", EmitDefaultValue = false)]
    [JsonPropertyName("vlak")]
    public Surface Vlak { get; set; }

    /// <summary>
    ///     Gets or Sets Multivlak
    /// </summary>
    [DataMember(Name = "multivlak", EmitDefaultValue = false)]
    [JsonPropertyName("multivlak")]
    public MultiSurface Multivlak { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VlakOfMultivlak {\n");
        sb.Append("  Vlak: ").Append(Vlak).Append("\n");
        sb.Append("  Multivlak: ").Append(Multivlak).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}