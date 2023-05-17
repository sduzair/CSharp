namespace csharpdddentity;

internal interface IEntity<TId> where TId : struct
{
    TId Id { get; init; }
}

internal abstract class Entity
{
}
