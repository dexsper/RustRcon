namespace RustRcon.Utility;

/// <summary>
///     A read-only view of a <see cref="ReactiveProperty{T}"/> that still exposes
///     <see cref="ValueChanged"/> for observation.
/// </summary>
public sealed class ReadOnlyReactiveProperty<T>
{
    private readonly ReactiveProperty<T> _source;

    /// <inheritdoc cref="ReactiveProperty{T}.Value"/>
    public T Value => _source.Value;

    /// <inheritdoc cref="ReactiveProperty{T}.ValueChanged"/>
    public event Action<T>? ValueChanged
    {
        add => _source.ValueChanged += value;
        remove => _source.ValueChanged -= value;
    }

    /// <param name="source">The underlying mutable property to observe.</param>
    /// <exception cref="ArgumentNullException"/>
    public ReadOnlyReactiveProperty(ReactiveProperty<T> source)
    {
        _source = source ?? throw new ArgumentNullException(nameof(source));
    }
}
