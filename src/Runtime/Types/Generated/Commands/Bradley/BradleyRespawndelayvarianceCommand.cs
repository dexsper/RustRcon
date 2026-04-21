using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Random variance multiplier applied to respawnDelayMinutes; a value of 1.0 means the actual delay is randomly chosen between 0 and respawnDelayMinutes</summary>
/// <remarks>Full RCON name: <c>bradley.respawndelayvariance</c></remarks>
public sealed class BradleyRespawndelayvarianceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradley.respawndelayvariance";

    /// <summary>Reads the current value of <c>bradley.respawndelayvariance</c>.</summary>
    public static BradleyRespawndelayvarianceCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyRespawndelayvarianceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradley.respawndelayvariance</c> to <paramref name="value"/>.</summary>
    public static BradleyRespawndelayvarianceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BradleyRespawndelayvarianceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
