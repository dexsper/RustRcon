using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, base entities are networked to all clients regardless of distance; disabling restricts base updates to players within the normal visibility radius</summary>
/// <remarks>Full RCON name: <c>net.global_networked_bases</c></remarks>
public sealed class NetGlobalNetworkedBasesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "net.global_networked_bases";

    /// <summary>Reads the current value of <c>net.global_networked_bases</c>.</summary>
    public static NetGlobalNetworkedBasesCommand CreateGet()
    {
        var cmd = CreatePackage<NetGlobalNetworkedBasesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>net.global_networked_bases</c> to <paramref name="value"/>.</summary>
    public static NetGlobalNetworkedBasesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<NetGlobalNetworkedBasesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
