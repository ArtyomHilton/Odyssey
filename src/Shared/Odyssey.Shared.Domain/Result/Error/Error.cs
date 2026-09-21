namespace Odyssey.Shared.Domain.Result.Error;

public sealed class Error
{
    public string Description { get; init; } = null!;
    public ErrorType Type { get; init; }

    private Error(string description, ErrorType type)
    {
        Description = description;
        Type = type;
    }

    public static Error Failure(string description) =>
        new Error(description, ErrorType.Failure);
    
    public static Error Validation(string description) =>
        new Error(description, ErrorType.Validation);
    
    public static Error NotFound(string description) =>
        new Error(description, ErrorType.NotFound);
    
    public static Error UnAuthorized(string description) =>
        new Error(description, ErrorType.UnAuthorized);
}