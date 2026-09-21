namespace Odyssey.Shared.Domain.Abstractions;

public interface IEntity { }

public interface IEntity<TEntityId>
{ 
    TEntityId Id { get; init; }
}