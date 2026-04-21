using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, draws debug visualisations for this system (seismic sensor range sphere, escape capture state, etc.); editor/admin-only</summary>
/// <remarks>Full RCON name: <c>ridablehorse.debug</c></remarks>
public sealed class RidablehorseDebugCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ridablehorse.debug";

    /// <summary>Reads the current value of <c>ridablehorse.debug</c>.</summary>
    public static RidablehorseDebugCommand CreateGet()
    {
        var cmd = CreatePackage<RidablehorseDebugCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ridablehorse.debug</c> to <paramref name="value"/>.</summary>
    public static RidablehorseDebugCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RidablehorseDebugCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
