using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>When enabled industrial transfers will abort if they start to take too long. Will lead to inconsistent splitting but should retain performance</summary>
/// <remarks>Full RCON name: <c>server.industrialtransferstricttimelimits</c></remarks>
public sealed class ServerIndustrialtransferstricttimelimitsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.industrialtransferstricttimelimits";

    /// <summary>Reads the current value of <c>server.industrialtransferstricttimelimits</c>.</summary>
    public static ServerIndustrialtransferstricttimelimitsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerIndustrialtransferstricttimelimitsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.industrialtransferstricttimelimits</c> to <paramref name="value"/>.</summary>
    public static ServerIndustrialtransferstricttimelimitsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerIndustrialtransferstricttimelimitsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
