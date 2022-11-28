using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class MultipolygonGeoJSON
{
    /// <summary>
    ///     Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    ///     Gets or Sets Coordinates
    /// </summary>
    [DataMember(Name = "coordinates", EmitDefaultValue = false)]
    [JsonPropertyName("coordinates")]
    public List<List<List<List<decimal?>>>> Coordinates { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MultipolygonGeoJSON {\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}