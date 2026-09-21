namespace Odyssey.Shared.Domain.Result;

public class Result
{
    public bool IsSuccess => _isSuccess;
    public bool IsFailure => !_isSuccess;

    public Error.Error Error => !_isSuccess
        ? _error!
        : throw new InvalidOperationException("Нельзя получить ошибку при успешном результате");

    private readonly bool _isSuccess;
    private readonly Error.Error? _error;

    protected Result(bool isSuccess, Error.Error? error)
    {
        _isSuccess = isSuccess;
        _error = error;
    }

    internal static Result Success() =>
        new Result(true, null);

    internal static Result Failure(Error.Error error) =>
        new Result(false, error);
}

public class Result<TValue> : Result
{
    private readonly TValue? _value;

    public TValue Value => IsSuccess
        ? _value!
        : throw new InvalidOperationException("Нельзя получить ошибку при успешном результате");

    protected Result(TValue? value, bool isSuccess, Error.Error? error) : base(isSuccess, error)
    {
        _value = value;
    }

    internal static Result<TValue> Success(TValue value) =>
        new Result<TValue>(value, true, null);

    internal new static Result<TValue> Failure(Error.Error error) =>
        new Result<TValue>(default(TValue), false, error);
}