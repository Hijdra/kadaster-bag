using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class AdresIO : Adres
{
    /// <summary>
    ///     Gets or Sets Geconstateerd
    /// </summary>
    [DataMember(Name = "geconstateerd", EmitDefaultValue = false)]
    [JsonPropertyName("geconstateerd")]
    public Geconstateerd Geconstateerd { get; set; }

    /// <summary>
    ///     Gets or Sets Inonderzoek
    /// </summary>
    [DataMember(Name = "inonderzoek", EmitDefaultValue = false)]
    [JsonPropertyName("inonderzoek")]
    public AdresInOnderzoek Inonderzoek { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresIO {\n");
        sb.Append("  Geconstateerd: ").Append(Geconstateerd).Append("\n");
        sb.Append("  Inonderzoek: ").Append(Inonderzoek).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}