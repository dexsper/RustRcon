using System.Collections;

namespace RustRcon.Pooling;

/// <summary>
///     A poolable wrapper around <see cref="List{T}"/>.
///     The internal list is cleared automatically when the instance is returned to the pool.
/// </summary>
/// <typeparam name="T">Element type.</typeparam>
public sealed class PoolableList<T> : BasePoolable, IEnumerable<T>
{
    private readonly List<T> _list = new();

    /// <summary>Gets the number of elements in the list.</summary>
    public int Count => _list.Count;

    /// <summary>Gets or sets the element at <paramref name="index"/>.</summary>
    public T this[int index]
    {
        get => _list[index];
        set => _list[index] = value;
    }

    /// <summary>Adds <paramref name="item"/> to the list.</summary>
    public void Add(T item) => _list.Add(item);

    /// <summary>Appends all elements of <paramref name="items"/> to the list.</summary>
    public void AddRange(IEnumerable<T> items) => _list.AddRange(items);

    /// <summary>Removes <paramref name="item"/> from the list.</summary>
    public bool Remove(T item) => _list.Remove(item);

    /// <summary>Removes all elements from the list.</summary>
    public void Clear() => _list.Clear();

    /// <summary>Returns a new <see cref="List{T}"/> containing a copy of all elements.</summary>
    public List<T> ToList() => new(_list);

    /// <inheritdoc/>
    public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    protected override void EnterPool()
    {
        base.EnterPool();
        _list.Clear();
    }
}
