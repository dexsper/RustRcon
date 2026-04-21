using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Log failed attempts and attempts from banned IP addresses (default: true)</summary>
/// <remarks>Full RCON name: <c>rcon.logfailedattempts</c></remarks>
public sealed class RconLogfailedattemptsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.logfailedattempts";

    /// <summary>Reads the current value of <c>rcon.logfailedattempts</c>.</summary>
    public static RconLogfailedattemptsCommand CreateGet()
    {
        var cmd = CreatePackage<RconLogfailedattemptsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.logfailedattempts</c> to <paramref name="value"/>.</summary>
    public static RconLogfailedattemptsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RconLogfailedattemptsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
