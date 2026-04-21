namespace RustRcon.Generator.Analysis.Models;

/// <summary>Describes a single parameter on a generated command's <c>Create</c> factory.</summary>
public sealed class CommandParameter
{
    /// <summary>C# type name, e.g. <c>string</c>, <c>int</c>, <c>SteamId</c>.</summary>
    public string TypeName { get; init; } = "string";

    /// <summary>Parameter name, e.g. <c>message</c>, <c>steamId</c>.</summary>
    public string ParameterName { get; init; } = "args";

    /// <summary>
    ///     The raw flag string passed to <c>arg.HasArg()</c>, e.g. <c>--json</c>.
    ///     <see langword="null"/> for ordinary positional parameters.
    /// </summary>
    public string? FlagName { get; init; }

    /// <summary>
    ///     <see langword="true"/> when this is an optional <c>arg.HasArg</c>-style flag
    ///     (passed as <c>--flagname</c> on the command line) rather than a positional argument.
    /// </summary>
    public bool IsFlag => FlagName is not null;
}
