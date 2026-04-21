using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.killscientistsonbradleydeath</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.killscientistsonbradleydeath</c></remarks>
public sealed class BradleyapcKillscientistsonbradleydeathCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.killscientistsonbradleydeath";

    /// <summary>Reads the current value of <c>bradleyapc.killscientistsonbradleydeath</c>.</summary>
    public static BradleyapcKillscientistsonbradleydeathCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyapcKillscientistsonbradleydeathCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradleyapc.killscientistsonbradleydeath</c> to <paramref name="value"/>.</summary>
    public static BradleyapcKillscientistsonbradleydeathCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BradleyapcKillscientistsonbradleydeathCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
