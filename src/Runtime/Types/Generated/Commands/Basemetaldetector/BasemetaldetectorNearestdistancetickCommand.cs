using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between nearest-detectable-object distance checks performed by the metal detector</summary>
/// <remarks>Full RCON name: <c>basemetaldetector.nearestdistancetick</c></remarks>
public sealed class BasemetaldetectorNearestdistancetickCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basemetaldetector.nearestdistancetick";

    /// <summary>Reads the current value of <c>basemetaldetector.nearestdistancetick</c>.</summary>
    public static BasemetaldetectorNearestdistancetickCommand CreateGet()
    {
        var cmd = CreatePackage<BasemetaldetectorNearestdistancetickCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basemetaldetector.nearestdistancetick</c> to <paramref name="value"/>.</summary>
    public static BasemetaldetectorNearestdistancetickCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasemetaldetectorNearestdistancetickCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
