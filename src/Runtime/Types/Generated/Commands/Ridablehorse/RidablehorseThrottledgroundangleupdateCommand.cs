using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, ground angle updates for horse body tilt are throttled to groundAngleUpdateRate seconds; improves performance</summary>
/// <remarks>Full RCON name: <c>ridablehorse.throttledgroundangleupdate</c></remarks>
public sealed class RidablehorseThrottledgroundangleupdateCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ridablehorse.throttledgroundangleupdate";

    /// <summary>Reads the current value of <c>ridablehorse.throttledgroundangleupdate</c>.</summary>
    public static RidablehorseThrottledgroundangleupdateCommand CreateGet()
    {
        var cmd = CreatePackage<RidablehorseThrottledgroundangleupdateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ridablehorse.throttledgroundangleupdate</c> to <paramref name="value"/>.</summary>
    public static RidablehorseThrottledgroundangleupdateCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RidablehorseThrottledgroundangleupdateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
