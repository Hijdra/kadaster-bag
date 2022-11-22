using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class AdresseerbareObjectenIOHalCollectionEmbedded
{
    /// <summary>
    ///     Gets or Sets AdresseerbareObjecten
    /// </summary>
    [DataMember(Name = "adresseerbareObjecten", EmitDefaultValue = false)]
    [JsonPropertyName("adresseerbareObjecten")]
    public List<AdresseerbaarObjectIOHal> AdresseerbareObjecten { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdresseerbareObjectenIOHalCollectionEmbedded {\n");
        sb.Append("  AdresseerbareObjecten: ").Append(AdresseerbareObjecten).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}