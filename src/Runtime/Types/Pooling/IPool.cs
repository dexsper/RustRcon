namespace RustRcon.Pooling;

/// <summary>Represents a pool capable of clearing its stored instances.</summary>
public interface IPool
{
    /// <summary>Removes all items currently held in the pool.</summary>
    void Clear();
}
