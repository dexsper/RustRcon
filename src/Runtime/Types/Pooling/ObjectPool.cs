namespace RustRcon.Pooling;

/// <summary>
///     A singleton pool for objects of type <typeparamref name="T"/> that inherit
///     <see cref="BasePoolable"/>.
/// </summary>
/// <typeparam name="T">The concrete poolable type.</typeparam>
public sealed class ObjectPool<T> : BasePool<BasePoolable> where T : BasePoolable, new()
{
    /// <summary>The shared pool instance for <typeparamref name="T"/>.</summary>
    public static readonly IPool<BasePoolable> Instance = new ObjectPool<T>();

    private ObjectPool() : base(1024) { }

    protected override BasePoolable CreateNew()
    {
        var obj = new T();
        obj.OnInit(this);
        return obj;
    }

    protected override void OnGetItem(BasePoolable item) => item.LeavePoolInternal();

    protected override bool OnFreeItem(ref BasePoolable item)
    {
        if (item.IsInPool)
            return false;

        item.EnterPoolInternal();
        return true;
    }
}
