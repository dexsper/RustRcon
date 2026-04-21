using System.Runtime.CompilerServices;

namespace RustRcon.Types.Span;

/// <summary>
///     Enables <c>foreach</c>-based splitting of a <see cref="ReadOnlySpan{T}"/> by a separator
///     without heap allocations.
/// </summary>
public readonly ref struct SpanSplitter<T> where T : IEquatable<T>
{
    private readonly ReadOnlySpan<T> _source;
    private readonly ReadOnlySpan<T> _separator;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public SpanSplitter(ReadOnlySpan<T> source, ReadOnlySpan<T> separator)
    {
        if (separator.Length == 0)
            throw new ArgumentException("Separator must be non-empty.", nameof(separator));

        _source = source;
        _separator = separator;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public SpanSplitEnumerator<T> GetEnumerator() => new(_source, _separator);
}
