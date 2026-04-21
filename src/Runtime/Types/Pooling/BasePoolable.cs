namespace RustRcon.Pooling;

/// <summary>
///     Base class for objects that can be returned to an <see cref="IPool{T}"/> for reuse.
/// </summary>
public abstract class BasePoolable : IDisposable
{
    /// <summary>
    ///     <see langword="true"/> while the object resides inside the pool (i.e. it is not
    ///     currently in use).  Do not access pooled objects when this flag is set.
    /// </summary>
    internal bool IsInPool;

    /// <summary>
    ///     <see langword="true"/> when this instance was obtained from a pool (as opposed to
    ///     being created with <c>new</c>).  Only instances that originate from a pool are
    ///     returned to it on <see cref="Dispose"/>.
    /// </summary>
    private bool _shouldPool;
    private IPool<BasePoolable> _pool = null!;

    internal void OnInit(IPool<BasePoolable> pool)
    {
        _pool = pool;
    }

    internal void EnterPoolInternal()
    {
        EnterPool();
        _shouldPool = false;
        IsInPool = true;
    }

    internal void LeavePoolInternal()
    {
        _shouldPool = true;
        IsInPool = false;
        LeavePool();
    }

    /// <summary>
    ///     Called when the object is returned to the pool.
    ///     Override to reset fields to their default state.
    /// </summary>
    protected virtual void EnterPool() { }

    /// <summary>
    ///     Called just after the object leaves the pool.
    ///     Override to set initial field values before first use.
    /// </summary>
    protected virtual void LeavePool() { }

    /// <inheritdoc/>
    /// <remarks>
    ///     If this instance came from a pool (<see cref="_shouldPool"/> is <see langword="true"/>),
    ///     it is returned to the pool.  Calling <see cref="Dispose"/> on an instance that is
    ///     already inside the pool throws <see cref="ObjectDisposedException"/>.
    /// </remarks>
    public virtual void Dispose()
    {
        if (!_shouldPool)
            return;

        if (IsInPool)
            throw new ObjectDisposedException(GetType().Name);

        _pool.Free(this);
    }
}
