using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class VerblijfsobjectEmbedded
{
    /// <summary>
    ///     Gets or Sets HeeftAlsHoofdAdres
    /// </summary>
    [DataMember(Name = "heeftAlsHoofdAdres", EmitDefaultValue = false)]
    [JsonPropertyName("heeftAlsHoofdAdres")]
    public NummeraanduidingIOHal HeeftAlsHoofdAdres { get; set; }

    /// <summary>
    ///     Gets or Sets HeeftAlsNevenAdres
    /// </summary>
    [DataMember(Name = "heeftAlsNevenAdres", EmitDefaultValue = false)]
    [JsonPropertyName("heeftAlsNevenAdres")]
    public List<NummeraanduidingIOHal> HeeftAlsNevenAdres { get; set; }

    /// <summary>
    ///     Gets or Sets MaaktDeelUitVan
    /// </summary>
    [DataMember(Name = "maaktDeelUitVan", EmitDefaultValue = false)]
    [JsonPropertyName("maaktDeelUitVan")]
    public List<PandIOHal> MaaktDeelUitVan { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VerblijfsobjectEmbedded {\n");
        sb.Append("  HeeftAlsHoofdAdres: ").Append(HeeftAlsHoofdAdres).Append("\n");
        sb.Append("  HeeftAlsNevenAdres: ").Append(HeeftAlsNevenAdres).Append("\n");
        sb.Append("  MaaktDeelUitVan: ").Append(MaaktDeelUitVan).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}