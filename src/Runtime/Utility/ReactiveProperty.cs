namespace RustRcon.Utility;

/// <summary>
///     A simple observable property that raises <see cref="ValueChanged"/> when its
///     value is modified.
/// </summary>
/// <remarks>
///     This class is not thread-safe. Access <see cref="Value"/> and subscribe to
///     <see cref="ValueChanged"/> from a single thread.
/// </remarks>
public sealed class ReactiveProperty<T>
{
    private T _value;

    /// <summary>Raised after <see cref="Value"/> changes.</summary>
    public event Action<T>? ValueChanged;

    /// <param name="initialValue">The starting value.</param>
    public ReactiveProperty(T initialValue = default!)
    {
        _value = initialValue;
    }

    /// <summary>
    ///     Gets or sets the current value.
    ///     Setting raises <see cref="ValueChanged"/> only when the new value differs
    ///     from the current one.
    /// </summary>
    public T Value
    {
        get => _value;
        set
        {
            if (EqualityComparer<T>.Default.Equals(_value, value)) return;
            _value = value;
            ValueChanged?.Invoke(_value);
        }
    }
}
