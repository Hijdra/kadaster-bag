using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Abstract type adresseerbaar object
/// </summary>
[DataContract]
public class AdresseerbaarObject
{
    /// <summary>
    ///     Gets or Sets HeeftAlsHoofdAdres
    /// </summary>
    [DataMember(Name = "heeftAlsHoofdAdres", EmitDefaultValue = false)]
    [JsonPropertyName("heeftAlsHoofdAdres")]
    public string HeeftAlsHoofdAdres { get; set; }

    /// <summary>
    ///     Gets or Sets HeeftAlsNevenAdres
    /// </summary>
    [DataMember(Name = "heeftAlsNevenAdres", EmitDefaultValue = false)]
    [JsonPropertyName("heeftAlsNevenAdres")]
    public List<string> HeeftAlsNevenAdres { get; set; }

    /// <summary>
    ///     Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonPropertyName("type")]
    public TypeAdresseerbaarObject Type { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresseerbaarObject {\n");
        sb.Append("  HeeftAlsHoofdAdres: ").Append(HeeftAlsHoofdAdres).Append("\n");
        sb.Append("  HeeftAlsNevenAdres: ").Append(HeeftAlsNevenAdres).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}