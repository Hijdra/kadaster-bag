using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class HalPaginationLinks : HalCollectionLinks
{
    /// <summary>
    ///     Gets or Sets First
    /// </summary>
    [DataMember(Name = "first", EmitDefaultValue = false)]
    [JsonPropertyName("first")]
    public HalLink First { get; set; }

    /// <summary>
    ///     Gets or Sets Previous
    /// </summary>
    [DataMember(Name = "previous", EmitDefaultValue = false)]
    [JsonPropertyName("previous")]
    public HalLink Previous { get; set; }

    /// <summary>
    ///     Gets or Sets Next
    /// </summary>
    [DataMember(Name = "next", EmitDefaultValue = false)]
    [JsonPropertyName("next")]
    public HalLink Next { get; set; }

    /// <summary>
    ///     Gets or Sets Last
    /// </summary>
    [DataMember(Name = "last", EmitDefaultValue = false)]
    [JsonPropertyName("last")]
    public HalLink Last { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HalPaginationLinks {\n");
        sb.Append("  First: ").Append(First).Append("\n");
        sb.Append("  Previous: ").Append(Previous).Append("\n");
        sb.Append("  Next: ").Append(Next).Append("\n");
        sb.Append("  Last: ").Append(Last).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}