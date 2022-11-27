using System.Collections;

namespace IO.Kadaster.Bag.Models;

public class Guard
{
    public Exception? Exception { get; private set; }
    
    private Guard()
    {
    }
    
    public static Guard New() => new();
    public Guard NotNull<T>(T value, string message)
    {
        if (Exception != null) return this;

        if (value == null)
        {
            Exception = new ArgumentNullException(message);
        }

        return this;
    }

    public Guard NotEmpty<T>(T[] value, string message)
    {
        if (Exception != null) return this;

        if (value.Length == 0)
        {
            Exception = new ArgumentException(message);
        }

        return this;
    }

    public Guard NotEmpty<T>(T value, string message) where T : IEnumerable
    {
        if (Exception != null) return this;

        if (!value.GetEnumerator().MoveNext())
        {
            Exception = new ArgumentException(message);
        }

        return this;
    }

    public Guard On(Func<bool> func, Exception exception)
    {
        if (Exception != null) return this;

        if (func())
        {
            Exception = exception;
        }

        return this;
    }
}