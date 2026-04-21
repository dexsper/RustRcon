using System.Collections;

namespace RustRcon.Utility;

/// <summary>
///     A dictionary that returns <see langword="default"/> for missing keys
///     and removes entries when their value is set to <see langword="null"/>.
/// </summary>
public sealed class Hash<TKey, TValue> : IDictionary<TKey, TValue> where TKey : notnull
{
    private readonly IDictionary<TKey, TValue> _dictionary;

    public Hash()
    {
        _dictionary = new Dictionary<TKey, TValue>();
    }

    public Hash(IEqualityComparer<TKey> comparer)
    {
        _dictionary = new Dictionary<TKey, TValue>(comparer);
    }

    /// <summary>
    ///     Gets the value for <paramref name="key"/>, or <see langword="default"/> when
    ///     the key is absent.  Setting to <see langword="null"/> removes the entry.
    /// </summary>
    public TValue this[TKey key]
    {
        get => TryGetValue(key, out var value) ? value : default!;
        set
        {
            if (value is null)
                _dictionary.Remove(key);
            else
                _dictionary[key] = value;
        }
    }

    public ICollection<TKey> Keys => _dictionary.Keys;
    public ICollection<TValue> Values => _dictionary.Values;
    public int Count => _dictionary.Count;
    public bool IsReadOnly => _dictionary.IsReadOnly;

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => _dictionary.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public bool ContainsKey(TKey key) => _dictionary.ContainsKey(key);
    public bool Contains(KeyValuePair<TKey, TValue> item) => _dictionary.Contains(item);
    public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) => _dictionary.CopyTo(array, index);
    public bool TryGetValue(TKey key, out TValue value) => _dictionary.TryGetValue(key, out value!);
    public void Add(TKey key, TValue value) => _dictionary.Add(key, value);
    public void Add(KeyValuePair<TKey, TValue> item) => _dictionary.Add(item);
    public bool Remove(TKey key) => _dictionary.Remove(key);
    public bool Remove(KeyValuePair<TKey, TValue> item) => _dictionary.Remove(item);
    public void Clear() => _dictionary.Clear();
}
