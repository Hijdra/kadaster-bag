using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class ZoekResultaatLinks
{
    /// <summary>
    ///     Gets or Sets Adres
    /// </summary>
    [DataMember(Name = "adres", EmitDefaultValue = false)]
    [JsonPropertyName("adres")]
    public HalLink Adres { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ZoekResultaatLinks {\n");
        sb.Append("  Adres: ").Append(Adres).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}