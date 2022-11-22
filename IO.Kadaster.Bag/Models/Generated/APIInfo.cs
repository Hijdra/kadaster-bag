using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Algemene informatie voor gebruikers van de API.
/// </summary>
[DataContract]
public class APIInfo
{
    /// <summary>
    ///     De naam van de API.
    /// </summary>
    /// <value>De naam van de API.</value>
    [DataMember(Name = "api-name", EmitDefaultValue = false)]
    [JsonPropertyName("api-name")]
    public string ApiName { get; set; }

    /// <summary>
    ///     Versie van de API.
    /// </summary>
    /// <value>Versie van de API.</value>
    [DataMember(Name = "api-version", EmitDefaultValue = false)]
    [JsonPropertyName("api-version")]
    public string ApiVersion { get; set; }

    /// <summary>
    ///     Omschrijving van de API.
    /// </summary>
    /// <value>Omschrijving van de API.</value>
    [DataMember(Name = "api-description", EmitDefaultValue = false)]
    [JsonPropertyName("api-description")]
    public string ApiDescription { get; set; }

    /// <summary>
    ///     Naam van het informatiemodel dat als basis is genomen voor deze API.
    /// </summary>
    /// <value>Naam van het informatiemodel dat als basis is genomen voor deze API.</value>
    [DataMember(Name = "informationmodel", EmitDefaultValue = false)]
    [JsonPropertyName("informationmodel")]
    public string Informationmodel { get; set; }

    /// <summary>
    ///     Versie van het logische informatiemodel dat als basis is genomen voor deze API.
    /// </summary>
    /// <value>Versie van het logische informatiemodel dat als basis is genomen voor deze API.</value>
    [DataMember(Name = "informationmodel-version", EmitDefaultValue = false)]
    [JsonPropertyName("informationmodel-version")]
    public string InformationmodelVersion { get; set; }

    /// <summary>
    ///     Locatie (URI) van het logische informatiemodel die als basis is genomen voor deze API.
    /// </summary>
    /// <value>Locatie (URI) van het logische informatiemodel die als basis is genomen voor deze API.</value>
    [DataMember(Name = "informationmodel-location", EmitDefaultValue = false)]
    [JsonPropertyName("informationmodel-location")]
    public string InformationmodelLocation { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class APIInfo {\n");
        sb.Append("  ApiName: ").Append(ApiName).Append("\n");
        sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
        sb.Append("  ApiDescription: ").Append(ApiDescription).Append("\n");
        sb.Append("  Informationmodel: ").Append(Informationmodel).Append("\n");
        sb.Append("  InformationmodelVersion: ").Append(InformationmodelVersion).Append("\n");
        sb.Append("  InformationmodelLocation: ").Append(InformationmodelLocation).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}