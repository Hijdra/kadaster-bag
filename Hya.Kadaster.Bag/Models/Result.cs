namespace Hya.Kadaster.Bag.Models;

public class Result<T>
{
    private readonly bool _ok;
    private readonly Exception _exception;
    private readonly T _value;

    private Result(T value)
    {
        _ok = true;
        _value = value;
        _exception = new NotSupportedException();
    }

    private Result(Exception exception)
    {
        _ok = false;
        _value = default!;
        _exception = exception;
    }

    public TReturn On<TReturn>(Func<T, TReturn> success, Func<Exception, TReturn> failed)
    {
        return _ok
            ? success(_value)
            : failed(_exception);
    }

    public void On(Action<T> success, Action<Exception> failed)
    {
        if (_ok) success(_value);
        else failed(_exception);
    }

    public T GetOrThrow()
    {
        if (!_ok) throw _exception;
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