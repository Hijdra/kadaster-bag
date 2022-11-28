using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Bronhouder aangevuld met HAL link.
/// </summary>
[DataContract]
public class BronhouderHal
{
    /// <summary>
    ///     Gets or Sets Bronhouder
    /// </summary>
    [DataMember(Name = "bronhouder", EmitDefaultValue = false)]
    [JsonPropertyName("bronhouder")]
    public Gemeente Bronhouder { get; set; }

    /// <summary>
    ///     Gets or Sets Links
    /// </summary>
    [DataMember(Name = "_links", EmitDefaultValue = false)]
    [JsonPropertyName("_links")]
    public BronhouderLinks Links { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BronhouderHal {\n");
        sb.Append("  Bronhouder: ").Append(Bronhouder).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}