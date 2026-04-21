using System.Runtime.CompilerServices;
using RustRcon.Types.Span;

namespace RustRcon.Types;

/// <summary>Extension methods for span-based operations.</summary>
public static class Extensions
{
    /// <summary>Splits <paramref name="source"/> by <paramref name="separator"/> without allocations.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static SpanSplitter<T> Split<T>(this ReadOnlySpan<T> source, ReadOnlySpan<T> separator)
        where T : IEquatable<T> =>
        new(source, separator);

    /// <summary>Splits <paramref name="source"/> by <paramref name="separator"/> without allocations.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static SpanSplitter<T> Split<T>(this Span<T> source, ReadOnlySpan<T> separator)
        where T : IEquatable<T> =>
        new(source, separator);
}
