using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.stall_position_restrictions</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.stall_position_restrictions</c></remarks>
public sealed class AntihackStallPositionRestrictionsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.stall_position_restrictions";

    /// <summary>Reads the current value of <c>antihack.stall_position_restrictions</c>.</summary>
    public static AntihackStallPositionRestrictionsCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackStallPositionRestrictionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.stall_position_restrictions</c> to <paramref name="value"/>.</summary>
    public static AntihackStallPositionRestrictionsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackStallPositionRestrictionsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
