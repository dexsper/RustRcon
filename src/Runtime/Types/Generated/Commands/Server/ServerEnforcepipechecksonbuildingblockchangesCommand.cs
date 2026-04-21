using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Whether to check for illegal industrial pipes when changing building block states (roof bunkers)</summary>
/// <remarks>Full RCON name: <c>server.enforcepipechecksonbuildingblockchanges</c></remarks>
public sealed class ServerEnforcepipechecksonbuildingblockchangesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.enforcepipechecksonbuildingblockchanges";

    /// <summary>Reads the current value of <c>server.enforcepipechecksonbuildingblockchanges</c>.</summary>
    public static ServerEnforcepipechecksonbuildingblockchangesCommand CreateGet()
    {
        var cmd = CreatePackage<ServerEnforcepipechecksonbuildingblockchangesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.enforcepipechecksonbuildingblockchanges</c> to <paramref name="value"/>.</summary>
    public static ServerEnforcepipechecksonbuildingblockchangesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerEnforcepipechecksonbuildingblockchangesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
