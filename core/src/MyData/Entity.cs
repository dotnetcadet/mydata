namespace MyData;

public abstract class Entity
{
    /// <summary>
    /// 
    /// </summary>
    public abstract EntityKind Kind { get; }

    /// <summary>
    /// 
    /// </summary>
    public abstract EntityDomain Domain { get; }
}
