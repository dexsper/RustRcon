using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If set to true, npcs will attempt to place themselves on the navmesh if not on a navmesh when set destination is called.</summary>
/// <remarks>Full RCON name: <c>aimanager.setdestination_navmesh_failsafe</c></remarks>
public sealed class AimanagerSetdestinationNavmeshFailsafeCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimanager.setdestination_navmesh_failsafe";

    /// <summary>Reads the current value of <c>aimanager.setdestination_navmesh_failsafe</c>.</summary>
    public static AimanagerSetdestinationNavmeshFailsafeCommand CreateGet()
    {
        var cmd = CreatePackage<AimanagerSetdestinationNavmeshFailsafeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimanager.setdestination_navmesh_failsafe</c> to <paramref name="value"/>.</summary>
    public static AimanagerSetdestinationNavmeshFailsafeCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AimanagerSetdestinationNavmeshFailsafeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
