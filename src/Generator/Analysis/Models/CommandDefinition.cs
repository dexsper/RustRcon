namespace RustRcon.Generator.Analysis.Models;

/// <summary>
///     All metadata extracted from a single <c>new ConsoleSystem.Command { … }</c>
///     initialiser in the decompiled ConsoleGen source.
/// </summary>
public sealed class CommandDefinition
{
    /// <summary>Dotted full name, e.g. <c>adventcalendar.overrideadventcalendarday</c>.</summary>
    public string FullName { get; init; } = string.Empty;

    /// <summary>Parent group, e.g. <c>adventcalendar</c>.</summary>
    public string Parent { get; init; } = string.Empty;

    /// <summary>Short name, e.g. <c>overrideadventcalendarday</c>.</summary>
    public string Name { get; init; } = string.Empty;

    /// <summary><see langword="true"/> for ConVars (get/set); <see langword="false"/> for action commands.</summary>
    public bool Variable { get; init; }

    /// <summary>Whether the command requires server-admin privileges.</summary>
    public bool ServerAdmin { get; init; }

    /// <summary>Whether the command is restricted to RCON only (not in-game console).</summary>
    public bool RconOnly { get; init; }

    /// <summary>Whether the ConVar is persisted across restarts.</summary>
    public bool Saved { get; init; }

    /// <summary>Whether the ConVar is replicated to clients.</summary>
    public bool Replicated { get; init; }

    /// <summary>Description string from the <c>Description</c> field (sourced from <c>[ServerVar(Help="…")]</c>).</summary>
    public string Description { get; init; } = string.Empty;

    /// <summary>Raw text of the <c>SetOveride</c> delegate body.</summary>
    public string? SetOverrideBody { get; init; }

    /// <summary>Raw text of the <c>GetOveride</c> delegate body.</summary>
    public string? GetOverrideBody { get; init; }

    /// <summary>Raw text of the <c>Call</c> delegate body.</summary>
    public string? CallBody { get; init; }

    /// <summary>
    ///     Determined kind of command after type analysis.
    ///     Set by <c>TypeAnalyzer</c>.
    /// </summary>
    public CommandKind Kind { get; set; } = CommandKind.Unknown;

    /// <summary>Underlying C# type for ConVar commands (int/bool/float/string).</summary>
    public string? ConVarTypeName { get; set; }

    /// <summary>Fully-qualified C# return type for commands with <c>ReplyWithObject</c>.</summary>
    public string? ReturnTypeName { get; set; }

    /// <summary>Parameters for the <c>Create</c> factory method.</summary>
    public List<CommandParameter> Parameters { get; init; } = new();

    /// <summary>
    ///     <see langword="true"/> when the command requires a player caller
    ///     (e.g. <c>ArgEx.Player(arg)</c>) and therefore cannot be meaningfully
    ///     invoked via remote RCON. Such commands are excluded from code generation.
    /// </summary>
    public bool RequiresPlayer { get; set; }
}
