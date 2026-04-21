using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of minutes after the Bradley APC is destroyed before it respawns at its patrol path; default is 60 minutes</summary>
/// <remarks>Full RCON name: <c>bradley.respawndelayminutes</c></remarks>
public sealed class BradleyRespawndelayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradley.respawndelayminutes";

    /// <summary>Reads the current value of <c>bradley.respawndelayminutes</c>.</summary>
    public static BradleyRespawndelayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyRespawndelayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradley.respawndelayminutes</c> to <paramref name="value"/>.</summary>
    public static BradleyRespawndelayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BradleyRespawndelayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
