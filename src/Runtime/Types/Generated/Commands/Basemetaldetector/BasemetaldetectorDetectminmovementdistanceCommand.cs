using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum distance in metres the player must move before a new long-range detection check is triggered</summary>
/// <remarks>Full RCON name: <c>basemetaldetector.detectminmovementdistance</c></remarks>
public sealed class BasemetaldetectorDetectminmovementdistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basemetaldetector.detectminmovementdistance";

    /// <summary>Reads the current value of <c>basemetaldetector.detectminmovementdistance</c>.</summary>
    public static BasemetaldetectorDetectminmovementdistanceCommand CreateGet()
    {
        var cmd = CreatePackage<BasemetaldetectorDetectminmovementdistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basemetaldetector.detectminmovementdistance</c> to <paramref name="value"/>.</summary>
    public static BasemetaldetectorDetectminmovementdistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasemetaldetectorDetectminmovementdistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
