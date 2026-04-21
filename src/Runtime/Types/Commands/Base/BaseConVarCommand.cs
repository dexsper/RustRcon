using System.Globalization;
using RustRcon.Types.Response.Server;

namespace RustRcon.Types.Commands.Base;

/// <summary>
///     Base for RCON commands that correspond to a Rust ConVar (console variable).
///     Provides typed get/set semantics: send without a value to read, with a value to write.
/// </summary>
/// <typeparam name="T">
///     The underlying ConVar type: <see cref="int"/>, <see cref="long"/>,
///     <see cref="float"/>, <see cref="bool"/>, or <see cref="string"/>.
/// </typeparam>
public abstract class BaseConVarCommand<T> : BaseCommand
{
    /// <summary>The parsed ConVar value, available after <see cref="BaseCommand.Complete"/> is called.</summary>
    public T? Value { get; private set; }

    /// <inheritdoc/>
    public override void Complete(ServerResponse response)
    {
        if (Completed) return;
        base.Complete(response);

        try
        {
            Value = ParseValue(response.Content.Trim());
        }
        catch
        {
            // ignored
        }
    }

    /// <summary>
    ///     Converts the raw string returned by the server into <typeparamref name="T"/>.
    ///     Override for custom conversion logic.
    /// </summary>
    protected virtual T? ParseValue(string raw)
    {
        if (typeof(T) == typeof(bool))
            return (T)(object)ParseBool(raw);

        return (T)Convert.ChangeType(raw, typeof(T), CultureInfo.InvariantCulture);
    }

    /// <summary>
    ///     Parses Rust's boolean representation: <c>"1"</c> or <c>"true"</c> (case-insensitive).
    /// </summary>
    private static bool ParseBool(string raw) => raw == "1" || raw.Equals("true", StringComparison.OrdinalIgnoreCase);

    protected override void EnterPool()
    {
        base.EnterPool();
        Value = default;
    }
}
