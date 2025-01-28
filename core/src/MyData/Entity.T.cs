namespace MyData;

public abstract class Entity<T> where T : Entity<T>
{
    /// <summary>
    /// 
    /// </summary>
    public Reference? Reference { get; set; }
}
