using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When true, uses the old sprinkler initialisation process when loading a save; enable if upgrading from an older server version to avoid sprinkler layout issues</summary>
/// <remarks>Full RCON name: <c>server.uselegacysprinklerloadprocess</c></remarks>
public sealed class ServerUselegacysprinklerloadprocessCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.uselegacysprinklerloadprocess";

    /// <summary>Reads the current value of <c>server.uselegacysprinklerloadprocess</c>.</summary>
    public static ServerUselegacysprinklerloadprocessCommand CreateGet()
    {
        var cmd = CreatePackage<ServerUselegacysprinklerloadprocessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.uselegacysprinklerloadprocess</c> to <paramref name="value"/>.</summary>
    public static ServerUselegacysprinklerloadprocessCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerUselegacysprinklerloadprocessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
