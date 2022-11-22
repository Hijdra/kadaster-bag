using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een Pand is de kleinste, bij de totstandkoming functioneel en bouwkundig-constructief zelfstandige eenheid die
///     direct en duurzaam met de aarde is verbonden en betreedbaar en afsluitbaar is. Inclusief aanduiding of deze in
///     onderzoek is
/// </summary>
[DataContract]
public class PandIOHal
{
    /// <summary>
    ///     Gets or Sets Pand
    /// </summary>
    [DataMember(Name = "pand", EmitDefaultValue = false)]
    [JsonPropertyName("pand")]
    public Pand Pand { get; set; }

    /// <summary>
    ///     Gets or Sets Inonderzoek
    /// </summary>
    [DataMember(Name = "inonderzoek", EmitDefaultValue = false)]
    [JsonPropertyName("inonderzoek")]
    public List<KenmerkPandInOnderzoek> Inonderzoek { get; set; }

    /// <summary>
    ///     Gets or Sets Links
    /// </summary>
    [DataMember(Name = "_links", EmitDefaultValue = false)]
    [JsonPropertyName("_links")]
    public PandLinks Links { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PandIOHal {\n");
        sb.Append("  Pand: ").Append(Pand).Append("\n");
        sb.Append("  Inonderzoek: ").Append(Inonderzoek).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}