namespace Odyssey.Shared.Domain.Result;

public static class ResultExtensions
{
    extension(Result result)
    {
        public Result Success() =>
            Result.Success();

        public Result Failure(Error.Error error) =>
            Result.Failure(error);
    }

    extension<TValue>(Result<TValue> result)
    {
        public Result<TValue> Success(TValue value) =>
            Result<TValue>.Success(value);

        public Result<TValue> Failure(Error.Error error) =>
            Result<TValue>.Failure(error);
    }
}