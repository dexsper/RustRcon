namespace RustRcon.Pooling;

/// <summary>
///     A fixed-capacity, thread-safe object pool using a stack-like array.
///     Items beyond <c>maxSize</c> that are freed are simply discarded.
/// </summary>
/// <typeparam name="T">Type being pooled. Must be a reference type.</typeparam>
public abstract class BasePool<T> : IPool<T> where T : class
{
    private readonly T?[] _pool;
    private readonly object _lock = new();
    private int _index;

    /// <summary>
    ///     Initialises the pool with the given capacity and registers it with
    ///     <see cref="RustRconPool"/>.
    /// </summary>
    /// <param name="maxSize">Maximum number of idle instances to retain.</param>
    protected BasePool(int maxSize)
    {
        _pool = new T[maxSize];
        RustRconPool.AddPool(this);
    }

    /// <summary>
    ///     Returns an idle instance from the pool, or creates a new one if the pool is empty.
    /// </summary>
    public T Get()
    {
        T? item = null;

        lock (_lock)
        {
            if (_index < _pool.Length)
            {
                item = _pool[_index];
                _pool[_index] = null;
                _index++;
            }
        }

        item ??= CreateNew();
        OnGetItem(item);
        return item;
    }

    /// <summary>Creates a new instance of <typeparamref name="T"/>.</summary>
    protected abstract T CreateNew();

    /// <summary>Returns <paramref name="item"/> to the pool.</summary>
    public void Free(T? item) => Free(ref item);

    private void Free(ref T? item)
    {
        if (item is null)
            return;

        if (!OnFreeItem(ref item))
            return;

        lock (_lock)
        {
            if (_index != 0)
            {
                _index--;
                _pool[_index] = item;
            }
        }

        item = null;
    }

    /// <summary>Called after an item is retrieved from the pool.</summary>
    protected virtual void OnGetItem(T item) { }

    /// <summary>
    ///     Called before an item is returned to the pool.
    ///     Return <see langword="false"/> to discard the item instead of pooling it.
    /// </summary>
    protected virtual bool OnFreeItem(ref T item) => true;

    /// <inheritdoc/>
    public void Clear()
    {
        lock (_lock)
        {
            for (int i = 0; i < _pool.Length; i++)
                _pool[i] = null;

            _index = 0;
        }
    }
}
