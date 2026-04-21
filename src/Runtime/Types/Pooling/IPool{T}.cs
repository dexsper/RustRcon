namespace RustRcon.Pooling;

/// <summary>
///     Represents an object pool for <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type managed by this pool.</typeparam>
public interface IPool<T> : IPool
{
    /// <summary>
    ///     Returns a pooled instance, or a newly created one if the pool is empty.
    /// </summary>
    T Get();

    /// <summary>Returns <paramref name="item"/> back to the pool for reuse.</summary>
    void Free(T item);
}
