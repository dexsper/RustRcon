using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, server occlusion is taken into account when updating player relationship visibility data; saved between restarts</summary>
/// <remarks>Full RCON name: <c>baseplayer.allowrelationshipserverocclusion</c></remarks>
public sealed class BaseplayerAllowrelationshipserverocclusionCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "baseplayer.allowrelationshipserverocclusion";

    /// <summary>Reads the current value of <c>baseplayer.allowrelationshipserverocclusion</c>.</summary>
    public static BaseplayerAllowrelationshipserverocclusionCommand CreateGet()
    {
        var cmd = CreatePackage<BaseplayerAllowrelationshipserverocclusionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>baseplayer.allowrelationshipserverocclusion</c> to <paramref name="value"/>.</summary>
    public static BaseplayerAllowrelationshipserverocclusionCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BaseplayerAllowrelationshipserverocclusionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
