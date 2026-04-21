namespace RustRcon.Generator.Analysis.Models;

/// <summary>Categorises the role of a generated RCON command class.</summary>
public enum CommandKind
{
    /// <summary>Not yet determined.</summary>
    Unknown,

    /// <summary>ConVar: supports both get (<c>parent.name</c>) and set (<c>parent.name value</c>).</summary>
    ConVar,

    /// <summary>Action command that returns a typed value via <c>arg.ReplyWithObject</c>.</summary>
    CallWithReturn,

    /// <summary>Action command that accepts a <see cref="SteamId"/> parameter.</summary>
    CallWithSteamId,

    /// <summary>Action command with one or more typed primitive parameters.</summary>
    CallWithParams,

    /// <summary>Action command with no meaningful parameters or return value.</summary>
    CallVoid,
}
