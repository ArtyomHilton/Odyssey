namespace Odyssey.Shared.Domain.Abstractions;

public interface IId<TId>
{
    public TId Value { get; init; }
}