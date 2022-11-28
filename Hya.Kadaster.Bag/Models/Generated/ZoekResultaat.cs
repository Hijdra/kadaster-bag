using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Resultaat van een zoekoperatie dat je kunt gebruiken om een adres te vinden met /adressen
/// </summary>
[DataContract]
public class ZoekResultaat
{
    /// <summary>
    ///     Omschrijving van het zoekresultaat
    /// </summary>
    /// <value>Omschrijving van het zoekresultaat</value>
    [DataMember(Name = "omschrijving", EmitDefaultValue = false)]
    [JsonPropertyName("omschrijving")]
    public string Omschrijving { get; set; }

    /// <summary>
    ///     Identificatie van het zoekresultaat
    /// </summary>
    /// <value>Identificatie van het zoekresultaat</value>
    [DataMember(Name = "identificatie", EmitDefaultValue = false)]
    [JsonPropertyName("identificatie")]
    public string Identificatie { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ZoekResultaat {\n");
        sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
        sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}