using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.usesmokegrenades</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.usesmokegrenades</c></remarks>
public sealed class BradleyapcUsesmokegrenadesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.usesmokegrenades";

    /// <summary>Reads the current value of <c>bradleyapc.usesmokegrenades</c>.</summary>
    public static BradleyapcUsesmokegrenadesCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyapcUsesmokegrenadesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradleyapc.usesmokegrenades</c> to <paramref name="value"/>.</summary>
    public static BradleyapcUsesmokegrenadesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BradleyapcUsesmokegrenadesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
