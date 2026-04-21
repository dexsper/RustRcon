using System.Runtime.CompilerServices;

namespace RustRcon.Types.Span;

/// <summary>
///     Enumerates segments of a <see cref="ReadOnlySpan{T}"/> delimited by a separator.
/// </summary>
public ref struct SpanSplitEnumerator<T> where T : IEquatable<T>
{
    private int _nextStartIndex;
    private readonly ReadOnlySpan<T> _separator;
    private readonly ReadOnlySpan<T> _source;
    private SpanSplitValue _current;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public SpanSplitEnumerator(ReadOnlySpan<T> source, ReadOnlySpan<T> separator)
    {
        if (separator.Length == 0)
            throw new ArgumentException("Separator must be non-empty.", nameof(separator));

        _nextStartIndex = 0;
        _source = source;
        _separator = separator;
        _current = default;
    }

    /// <summary>Advances to the next segment.</summary>
    public bool MoveNext()
    {
        if (_nextStartIndex > _source.Length)
            return false;

        var remaining = _source[_nextStartIndex..];
        var foundIndex = remaining.IndexOf(_separator);
        var length = foundIndex >= 0 ? foundIndex : remaining.Length;

        _current = new SpanSplitValue(_nextStartIndex, length, _source);
        _nextStartIndex += _separator.Length + _current.Length;
        return true;
    }

    /// <summary>The current segment.</summary>
    public SpanSplitValue Current
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _current;
    }

    /// <summary>A slice of the source span representing a single delimited segment.</summary>
    public readonly ref struct SpanSplitValue
    {
        public SpanSplitValue(int startIndex, int length, ReadOnlySpan<T> source)
        {
            StartIndex = startIndex;
            Length = length;
            Source = source;
        }

        public int StartIndex { get; }
        public int Length { get; }
        public ReadOnlySpan<T> Source { get; }

        /// <summary>Returns the segment as a <see cref="ReadOnlySpan{T}"/>.</summary>
        public ReadOnlySpan<T> AsSpan() => Source.Slice(StartIndex, Length);

        public static implicit operator ReadOnlySpan<T>(SpanSplitValue value) => value.AsSpan();
    }
}
