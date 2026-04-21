using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>world.cache</c>.</summary>
/// <remarks>Full RCON name: <c>world.cache</c></remarks>
public sealed class WorldCacheCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "world.cache";

    /// <summary>Reads the current value of <c>world.cache</c>.</summary>
    public static WorldCacheCommand CreateGet()
    {
        var cmd = CreatePackage<WorldCacheCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>world.cache</c> to <paramref name="value"/>.</summary>
    public static WorldCacheCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<WorldCacheCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
