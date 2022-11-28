namespace Hya.Kadaster.Bag.Models;

public class Result<T>
{
    private readonly Exception _exception;
    private readonly T? _value;

    private Result(T value)
    {
        _value = value;
        _exception = new NotSupportedException();
    }

    private Result(Exception exception)
    {
        _exception = exception;
    }

    public TReturn On<TReturn>(Func<T, TReturn> success, Func<Exception, TReturn> failed)
    {
        return _value != null
            ? success(_value)
            : failed(_exception);
    }

    public void On(Action<T> success, Action<Exception> failed)
    {
        if (_value != null) success(_value);
        else failed(_exception);
    }

    public T GetOrThrow()
    {
        if (_value == null) throw _exception;
        return _value;
    }

    public static implicit operator Result<T>(T value) => new(value);

    public static implicit operator Result<T>(Exception exception) => new(exception);

    public static implicit operator Result<T>(Guard guard)
    {
        return guard.Exception == null
            ? new Result<T>(new NotSupportedException("Exception in Guard is null"))
            : new Result<T>(guard.Exception);
    }
}