using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.enforcementlevel</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.enforcementlevel</c></remarks>
public sealed class AntihackEnforcementlevelCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.enforcementlevel";

    /// <summary>Reads the current value of <c>antihack.enforcementlevel</c>.</summary>
    public static AntihackEnforcementlevelCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEnforcementlevelCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.enforcementlevel</c> to <paramref name="value"/>.</summary>
    public static AntihackEnforcementlevelCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackEnforcementlevelCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
