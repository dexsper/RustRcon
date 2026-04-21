using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>render.show_building_blocked_server</c>.</summary>
/// <remarks>Full RCON name: <c>render.show_building_blocked_server</c></remarks>
public sealed class RenderShowBuildingBlockedServerCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "render.show_building_blocked_server";

    /// <summary>Reads the current value of <c>render.show_building_blocked_server</c>.</summary>
    public static RenderShowBuildingBlockedServerCommand CreateGet()
    {
        var cmd = CreatePackage<RenderShowBuildingBlockedServerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>render.show_building_blocked_server</c> to <paramref name="value"/>.</summary>
    public static RenderShowBuildingBlockedServerCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RenderShowBuildingBlockedServerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
