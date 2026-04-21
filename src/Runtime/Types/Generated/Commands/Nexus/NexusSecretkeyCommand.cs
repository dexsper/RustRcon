using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Shared secret key used to authenticate Nexus inter-server communication; must match across all servers in the same Nexus cluster</summary>
/// <remarks>Full RCON name: <c>nexus.secretkey</c></remarks>
public sealed class NexusSecretkeyCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.secretkey";

    /// <summary>Reads the current value of <c>nexus.secretkey</c>.</summary>
    public static NexusSecretkeyCommand CreateGet()
    {
        var cmd = CreatePackage<NexusSecretkeyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.secretkey</c> to <paramref name="value"/>.</summary>
    public static NexusSecretkeyCommand CreateSet(string value)
    {
        var cmd = CreatePackage<NexusSecretkeyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
