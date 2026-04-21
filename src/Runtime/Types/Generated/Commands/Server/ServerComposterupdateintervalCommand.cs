using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) How often (in seconds) composters advance their composting progress; default is every 300 seconds (5 minutes)</summary>
/// <remarks>Full RCON name: <c>server.composterupdateinterval</c></remarks>
public sealed class ServerComposterupdateintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.composterupdateinterval";

    /// <summary>Reads the current value of <c>server.composterupdateinterval</c>.</summary>
    public static ServerComposterupdateintervalCommand CreateGet()
    {
        var cmd = CreatePackage<ServerComposterupdateintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.composterupdateinterval</c> to <paramref name="value"/>.</summary>
    public static ServerComposterupdateintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerComposterupdateintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
