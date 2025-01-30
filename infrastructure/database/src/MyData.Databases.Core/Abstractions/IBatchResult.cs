namespace MyData.Databases;


public interface IBatchResult<T>
    where T : Entity, new()
{
    BatchResultState State { get;}
    T Entity { get; }
}
