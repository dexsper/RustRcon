using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.speedhack_protection</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.speedhack_protection</c></remarks>
public sealed class AntihackSpeedhackProtectionCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.speedhack_protection";

    /// <summary>Reads the current value of <c>antihack.speedhack_protection</c>.</summary>
    public static AntihackSpeedhackProtectionCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackSpeedhackProtectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.speedhack_protection</c> to <paramref name="value"/>.</summary>
    public static AntihackSpeedhackProtectionCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackSpeedhackProtectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
