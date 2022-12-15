using System.Collections;
using System.Text.RegularExpressions;

namespace Hya.Kadaster.Bag.Models;

public class Guard
{
    public Exception? Exception { get; private set; }

    private static readonly Regex DutchPostalCodeRegex = new(@"^\d{4} ?\w{2}$", RegexOptions.Compiled);

    private Guard()
    {
    }

    public static Guard New() => new();

    private Guard Wrap(Func<Exception?> func)
    {
        if (Exception != null) return this;

        Exception = func();

        return this;
    }

    public Guard NotNull<T>(T value, string message) => Wrap(
        () => value == null ? new ArgumentNullException(message) : null
    );

    public Guard NotNullOrEmpty(string value, string message) => Wrap(
        () => string.IsNullOrEmpty(value) ? new ArgumentNullException(message) : null
    );

    public Guard NotAny<T>(T[] value, string message) => Wrap(
        () => value.Length == 0 ? new ArgumentException(message) : null
    );

    public Guard NotAny<T>(T value, string message) where T : IEnumerable => Wrap(
        () => !value.GetEnumerator().MoveNext() ? new ArgumentException(message) : null
    );

    public Guard NotRange<T>(T value, T min, T max, string message) where T : IComparable<T> => Wrap(
        () => value.CompareTo(min) < 0 || value.CompareTo(max) > 0 ? new ArgumentOutOfRangeException(message) : null
    );

    public Guard On(Func<bool> func, Exception exception) => Wrap(
        () => func() ? exception : null
    );

    public Guard NotDutchPostalCode(string value) => Wrap(
        () => !DutchPostalCodeRegex.IsMatch(value) ? new ArgumentException("PostalCode does not have the correct format: 1234AB or 1234 AB") : null
    );
}