using System.Globalization;

namespace RustRcon.Types;

/// <summary>
///     Represents a Steam 64-bit user identifier.
///     Valid identifiers are ≥ 70,000,000,000,000,000.
/// </summary>
public readonly struct SteamId : IEquatable<SteamId>
{
    private const ulong MinValidId = 70_000_000_000_000_000UL;

    /// <summary>The raw 64-bit Steam ID value.</summary>
    public readonly ulong Value;

    /// <summary>Returns <see langword="true"/> when the ID meets the minimum Steam64 threshold.</summary>
    public bool IsValid => Value >= MinValidId;

    /// <param name="value">Raw Steam64 value.</param>
    public SteamId(ulong value) => Value = value;

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);

    /// <inheritdoc/>
    public bool Equals(SteamId other) => Value == other.Value;

    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is SteamId other && Equals(other);

    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    public static bool operator ==(SteamId left, SteamId right) => left.Value == right.Value;
    public static bool operator !=(SteamId left, SteamId right) => left.Value != right.Value;

    /// <summary>Implicitly converts a <see cref="SteamId"/> to its underlying <see cref="ulong"/> value.</summary>
    public static implicit operator ulong(SteamId id) => id.Value;

    /// <summary>Explicitly converts a raw <see cref="ulong"/> to a <see cref="SteamId"/>.</summary>
    public static explicit operator SteamId(ulong id) => new(id);
}
