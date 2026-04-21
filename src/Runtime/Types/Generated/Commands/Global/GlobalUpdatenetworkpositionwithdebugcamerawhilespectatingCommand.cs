using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When true, the server network position is updated to match the debug camera world position while spectating; useful for testing position-dependent server logic from the spectator view</summary>
/// <remarks>Full RCON name: <c>global.updatenetworkpositionwithdebugcamerawhilespectating</c></remarks>
public sealed class GlobalUpdatenetworkpositionwithdebugcamerawhilespectatingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.updatenetworkpositionwithdebugcamerawhilespectating";

    /// <summary>Reads the current value of <c>global.updatenetworkpositionwithdebugcamerawhilespectating</c>.</summary>
    public static GlobalUpdatenetworkpositionwithdebugcamerawhilespectatingCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalUpdatenetworkpositionwithdebugcamerawhilespectatingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.updatenetworkpositionwithdebugcamerawhilespectating</c> to <paramref name="value"/>.</summary>
    public static GlobalUpdatenetworkpositionwithdebugcamerawhilespectatingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<GlobalUpdatenetworkpositionwithdebugcamerawhilespectatingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
