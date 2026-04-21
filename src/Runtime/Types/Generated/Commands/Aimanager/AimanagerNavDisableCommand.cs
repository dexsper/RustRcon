using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If set to true the navmesh won't generate.. which means Ai that uses the navmesh won't be able to move</summary>
/// <remarks>Full RCON name: <c>aimanager.nav_disable</c></remarks>
public sealed class AimanagerNavDisableCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimanager.nav_disable";

    /// <summary>Reads the current value of <c>aimanager.nav_disable</c>.</summary>
    public static AimanagerNavDisableCommand CreateGet()
    {
        var cmd = CreatePackage<AimanagerNavDisableCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimanager.nav_disable</c> to <paramref name="value"/>.</summary>
    public static AimanagerNavDisableCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AimanagerNavDisableCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
