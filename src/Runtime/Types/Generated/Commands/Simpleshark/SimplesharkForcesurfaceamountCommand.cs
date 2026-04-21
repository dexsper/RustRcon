using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>simpleshark.forcesurfaceamount</c>.</summary>
/// <remarks>Full RCON name: <c>simpleshark.forcesurfaceamount</c></remarks>
public sealed class SimplesharkForcesurfaceamountCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "simpleshark.forcesurfaceamount";

    /// <summary>Reads the current value of <c>simpleshark.forcesurfaceamount</c>.</summary>
    public static SimplesharkForcesurfaceamountCommand CreateGet()
    {
        var cmd = CreatePackage<SimplesharkForcesurfaceamountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>simpleshark.forcesurfaceamount</c> to <paramref name="value"/>.</summary>
    public static SimplesharkForcesurfaceamountCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SimplesharkForcesurfaceamountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
