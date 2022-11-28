using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een adresseerbaar object kan een ligplaats, standplaats of verblijfsobject zijn, er wordt van onderstaande
///     properties dus altijd maar één ingevuld.
/// </summary>
[DataContract]
public class AdresseerbaarObjectIOHal
{
    /// <summary>
    ///     Gets or Sets Links
    /// </summary>
    [DataMember(Name = "_links", EmitDefaultValue = false)]
    [JsonPropertyName("_links")]
    public HalCollectionLinks Links { get; set; }

    /// <summary>
    ///     Gets or Sets Ligplaats
    /// </summary>
    [DataMember(Name = "ligplaats", EmitDefaultValue = false)]
    [JsonPropertyName("ligplaats")]
    public LigplaatsIOHal Ligplaats { get; set; }

    /// <summary>
    ///     Gets or Sets Standplaats
    /// </summary>
    [DataMember(Name = "standplaats", EmitDefaultValue = false)]
    [JsonPropertyName("standplaats")]
    public StandplaatsIOHal Standplaats { get; set; }

    /// <summary>
    ///     Gets or Sets Verblijfsobject
    /// </summary>
    [DataMember(Name = "verblijfsobject", EmitDefaultValue = false)]
    [JsonPropertyName("verblijfsobject")]
    public VerblijfsobjectIOHal Verblijfsobject { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresseerbaarObjectIOHal {\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("  Ligplaats: ").Append(Ligplaats).Append("\n");
        sb.Append("  Standplaats: ").Append(Standplaats).Append("\n");
        sb.Append("  Verblijfsobject: ").Append(Verblijfsobject).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}