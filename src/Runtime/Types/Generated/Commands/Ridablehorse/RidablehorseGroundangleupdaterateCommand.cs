using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between ground angle recalculation updates for horse body tilting; default 0.05s</summary>
/// <remarks>Full RCON name: <c>ridablehorse.groundangleupdaterate</c></remarks>
public sealed class RidablehorseGroundangleupdaterateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ridablehorse.groundangleupdaterate";

    /// <summary>Reads the current value of <c>ridablehorse.groundangleupdaterate</c>.</summary>
    public static RidablehorseGroundangleupdaterateCommand CreateGet()
    {
        var cmd = CreatePackage<RidablehorseGroundangleupdaterateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ridablehorse.groundangleupdaterate</c> to <paramref name="value"/>.</summary>
    public static RidablehorseGroundangleupdaterateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<RidablehorseGroundangleupdaterateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
