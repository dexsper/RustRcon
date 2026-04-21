using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If true, snowmobile goes fast on all terrain types</summary>
/// <remarks>Full RCON name: <c>snowmobile.allterrain</c></remarks>
public sealed class SnowmobileAllterrainCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "snowmobile.allterrain";

    /// <summary>Reads the current value of <c>snowmobile.allterrain</c>.</summary>
    public static SnowmobileAllterrainCommand CreateGet()
    {
        var cmd = CreatePackage<SnowmobileAllterrainCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>snowmobile.allterrain</c> to <paramref name="value"/>.</summary>
    public static SnowmobileAllterrainCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<SnowmobileAllterrainCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
