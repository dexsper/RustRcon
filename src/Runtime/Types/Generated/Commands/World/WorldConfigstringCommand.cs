using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) World generation config string passed directly to the procedural map generator; overrides the config file if set</summary>
/// <remarks>Full RCON name: <c>world.configstring</c></remarks>
public sealed class WorldConfigstringCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "world.configstring";

    /// <summary>Reads the current value of <c>world.configstring</c>.</summary>
    public static WorldConfigstringCommand CreateGet()
    {
        var cmd = CreatePackage<WorldConfigstringCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>world.configstring</c> to <paramref name="value"/>.</summary>
    public static WorldConfigstringCommand CreateSet(string value)
    {
        var cmd = CreatePackage<WorldConfigstringCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
