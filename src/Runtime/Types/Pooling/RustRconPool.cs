using RustRcon.Utility;

namespace RustRcon.Pooling;

/// <summary>
///     Central registry and entry point for object pooling.
///     Pools register themselves during their static initialisation via
///     <see cref="AddPool{TType}"/>.
/// </summary>
public static class RustRconPool
{
    private static readonly object PoolsLock = new();
    private static readonly Hash<Type, IPool> Pools = new();

    /// <summary>
    ///     Returns a pooled instance of <typeparamref name="T"/>, creating a new one if
    ///     the pool is empty.
    /// </summary>
    /// <typeparam name="T">
    ///     Type to retrieve.  Must inherit <see cref="BasePoolable"/> and expose a
    ///     public parameterless constructor.
    /// </typeparam>
    public static T Get<T>() where T : BasePoolable, new() => (T)ObjectPool<T>.Instance.Get();

    /// <summary>
    ///     Returns <paramref name="value"/> to its pool and sets the reference to
    ///     <see langword="null"/> so the caller cannot accidentally reuse it.
    /// </summary>
    public static void Free<T>(ref T? value) where T : BasePoolable, new()
    {
        if (value is null) return;
        ObjectPool<T>.Instance.Free(value);
        value = null;
    }

    /// <summary>Returns <paramref name="value"/> to its pool.</summary>
    internal static void Free<T>(T value) where T : BasePoolable, new() => ObjectPool<T>.Instance.Free(value);

    /// <summary>
    ///     Registers a pool instance.  Called automatically from
    ///     <see cref="BasePool{T}"/> constructors.
    /// </summary>
    public static void AddPool<TType>(BasePool<TType> pool) where TType : class
    {
        lock (PoolsLock)
            Pools[typeof(TType)] = pool;
    }
}