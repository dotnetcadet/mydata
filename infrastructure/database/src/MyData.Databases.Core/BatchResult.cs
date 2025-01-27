namespace MyData.Databases;

public sealed class BatchResult<T> : IBatchResult<T>
    where T : Entity<T>, new()
{
    public BatchResultState State { get; init; }
    public T Entity { get; init; } = default!;
}
