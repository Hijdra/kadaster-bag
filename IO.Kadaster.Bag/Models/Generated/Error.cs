using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
/// </summary>
[DataContract]
public class Error
{
    /// <summary>
    ///     De HTTP status code.
    /// </summary>
    /// <value>De HTTP status code.</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    ///     De titel behorende bij de HTTP status code.
    /// </summary>
    /// <value>De titel behorende bij de HTTP status code.</value>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    ///     URI naar een pagina met meer informatie over deze foutmelding voor de ontwikkelaar.
    /// </summary>
    /// <value>URI naar een pagina met meer informatie over deze foutmelding voor de ontwikkelaar. </value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    ///     Een gedetailleerde beschrijving van de HTTP status code.
    /// </summary>
    /// <value>Een gedetailleerde beschrijving van de HTTP status code.</value>
    [DataMember(Name = "detail", EmitDefaultValue = false)]
    [JsonPropertyName("detail")]
    public string Detail { get; set; }

    /// <summary>
    ///     URI van de aanroep die fout heeft veroorzaakt.
    /// </summary>
    /// <value>URI van de aanroep die fout heeft veroorzaakt.</value>
    [DataMember(Name = "instance", EmitDefaultValue = false)]
    [JsonPropertyName("instance")]
    public string Instance { get; set; }

    /// <summary>
    ///     Systeem code die het type fout aangeeft.
    /// </summary>
    /// <value>Systeem code die het type fout aangeeft.</value>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    [JsonPropertyName("code")]
    public string Code { get; set; }

    /// <summary>
    ///     Gets or Sets InvalidParams
    /// </summary>
    [DataMember(Name = "invalid-params", EmitDefaultValue = false)]
    [JsonPropertyName("invalid-params")]
    public List<InvalidParams> InvalidParams { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Error {\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Detail: ").Append(Detail).Append("\n");
        sb.Append("  Instance: ").Append(Instance).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  InvalidParams: ").Append(InvalidParams).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}