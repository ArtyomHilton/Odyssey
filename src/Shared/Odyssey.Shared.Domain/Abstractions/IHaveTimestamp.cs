namespace Odyssey.Shared.Domain.Abstractions;

public interface IHaveTimestamp
{
    DateTime CreatedAt { get; init; }
    DateTime UpdatedAt { get; init; }
}