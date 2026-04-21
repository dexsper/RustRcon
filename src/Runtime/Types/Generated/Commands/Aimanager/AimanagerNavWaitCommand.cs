using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If true we'll wait for the navmesh to generate before completely starting the server. This might cause your server to hitch and lag as it generates in the background.</summary>
/// <remarks>Full RCON name: <c>aimanager.nav_wait</c></remarks>
public sealed class AimanagerNavWaitCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimanager.nav_wait";

    /// <summary>Reads the current value of <c>aimanager.nav_wait</c>.</summary>
    public static AimanagerNavWaitCommand CreateGet()
    {
        var cmd = CreatePackage<AimanagerNavWaitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimanager.nav_wait</c> to <paramref name="value"/>.</summary>
    public static AimanagerNavWaitCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AimanagerNavWaitCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
