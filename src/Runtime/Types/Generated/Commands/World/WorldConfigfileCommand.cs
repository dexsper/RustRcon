using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Path to a world generation config file used by the procedural map generator; used when configString is empty</summary>
/// <remarks>Full RCON name: <c>world.configfile</c></remarks>
public sealed class WorldConfigfileCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "world.configfile";

    /// <summary>Reads the current value of <c>world.configfile</c>.</summary>
    public static WorldConfigfileCommand CreateGet()
    {
        var cmd = CreatePackage<WorldConfigfileCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>world.configfile</c> to <paramref name="value"/>.</summary>
    public static WorldConfigfileCommand CreateSet(string value)
    {
        var cmd = CreatePackage<WorldConfigfileCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
