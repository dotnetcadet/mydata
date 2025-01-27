namespace MyData.Databases;


public interface IBatchResult<T>
    where T : Entity<T>, new()
{
    BatchResultState State { get;}
    T Entity { get; }
}
