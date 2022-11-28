using System.Runtime.Serialization;
using System.Text;

namespace Hya.Kadaster.Bag.Models.Generated;

/// <summary>
///     Een aanduiding waarmee kan worden aangegeven of een attribuut van een object of data type een indicatie J (Ja) of N
///     (Nee) heeft in de registratie.
/// </summary>
[DataContract]
public class Indicatie
{
    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Indicatie {\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}