using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Port to listen for RCON connections</summary>
/// <remarks>Full RCON name: <c>rcon.port</c></remarks>
public sealed class RconPortCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.port";

    /// <summary>Reads the current value of <c>rcon.port</c>.</summary>
    public static RconPortCommand CreateGet()
    {
        var cmd = CreatePackage<RconPortCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.port</c> to <paramref name="value"/>.</summary>
    public static RconPortCommand CreateSet(int value)
    {
        var cmd = CreatePackage<RconPortCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
