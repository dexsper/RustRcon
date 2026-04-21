using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.build_inside_check</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.build_inside_check</c></remarks>
public sealed class AntihackBuildInsideCheckCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.build_inside_check";

    /// <summary>Reads the current value of <c>antihack.build_inside_check</c>.</summary>
    public static AntihackBuildInsideCheckCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackBuildInsideCheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.build_inside_check</c> to <paramref name="value"/>.</summary>
    public static AntihackBuildInsideCheckCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackBuildInsideCheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
