using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class LigplaatsLinks
{
    /// <summary>
    ///     Gets or Sets Self
    /// </summary>
    [DataMember(Name = "self", EmitDefaultValue = false)]
    [JsonPropertyName("self")]
    public HalLink Self { get; set; }

    /// <summary>
    ///     Gets or Sets HeeftAlsHoofdAdres
    /// </summary>
    [DataMember(Name = "heeftAlsHoofdAdres", EmitDefaultValue = false)]
    [JsonPropertyName("heeftAlsHoofdAdres")]
    public HalLink HeeftAlsHoofdAdres { get; set; }

    /// <summary>
    ///     De nummeraanduidingen die dit adresseerbare object als nevenadressen heeft. Van deze gerelateerd nummeraanduiding:
    ///     hiervan het voorkomen van nummeraanduiding die gevonden wordt op basis van dezelfde tijdreisparameters als waarmee
    ///     het adresseerbare object voorkomen gevonden is.
    /// </summary>
    /// <value>
    ///     De nummeraanduidingen die dit adresseerbare object als nevenadressen heeft. Van deze gerelateerd
    ///     nummeraanduiding: hiervan het voorkomen van nummeraanduiding die gevonden wordt op basis van dezelfde
    ///     tijdreisparameters als waarmee het adresseerbare object voorkomen gevonden is.
    /// </value>
    [DataMember(Name = "heeftAlsNevenAdres", EmitDefaultValue = false)]
    [JsonPropertyName("heeftAlsNevenAdres")]
    public List<HalLink> HeeftAlsNevenAdres { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LigplaatsLinks {\n");
        sb.Append("  Self: ").Append(Self).Append("\n");
        sb.Append("  HeeftAlsHoofdAdres: ").Append(HeeftAlsHoofdAdres).Append("\n");
        sb.Append("  HeeftAlsNevenAdres: ").Append(HeeftAlsNevenAdres).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}