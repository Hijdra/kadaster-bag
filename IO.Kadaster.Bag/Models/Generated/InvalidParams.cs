using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Kadaster.Bag.Models.Generated;

/// <summary>
///     Wanneer de fout is veroorzaakt door fouten in requestparameters (of request body),  wordt invalid-params gevuld met
///     details over elke foute parameter. Wanneer er fouten zitten op meerdere parameters, wordt er per validatiefout een
///     invalid-params instantie opgenomen in het antwoord.  Alle fouten worden dus teruggegeven. Een gedetailleerde
///     beschrijving hoe de onderstaande attributen ingevuld moeten  worden staat op:
///     https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/blob/master/features/foutafhandeling.feature\&quot;
/// </summary>
[DataContract]
public class InvalidParams
{
    /// <summary>
    ///     Een url naar een beschrijving van de fout in de parameter.  De hier gerefereerde foutbeschrijving is specifieker
    ///     dan type op het  hoofdniveau van het bericht.
    /// </summary>
    /// <value>
    ///     Een url naar een beschrijving van de fout in de parameter.  De hier gerefereerde foutbeschrijving is specifieker
    ///     dan type op het  hoofdniveau van het bericht.
    /// </value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    ///     De naam van de parameter waar de fout in zit.
    /// </summary>
    /// <value>De naam van de parameter waar de fout in zit.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    ///     Een vaste waarde afhankelijk van het soort fout.
    /// </summary>
    /// <value>Een vaste waarde afhankelijk van het soort fout.</value>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    [JsonPropertyName("code")]
    public string Code { get; set; }

    /// <summary>
    ///     Een vaste omschrijving afhankelijk van het soort fout.
    /// </summary>
    /// <value>Een vaste omschrijving afhankelijk van het soort fout.</value>
    [DataMember(Name = "reason", EmitDefaultValue = false)]
    [JsonPropertyName("reason")]
    public string Reason { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InvalidParams {\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}