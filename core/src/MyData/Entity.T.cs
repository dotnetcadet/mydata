namespace MyData;

public abstract class Entity<T> : Entity
    where T : Entity<T>
{
    /// <summary>
    /// 
    /// </summary>
    public Reference? Reference { get; set; }
}
