using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs network visibility group changes to the server console, showing when entities enter or leave a player visibility radius</summary>
/// <remarks>Full RCON name: <c>net.visdebug</c></remarks>
public sealed class NetVisdebugCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "net.visdebug";

    /// <summary>Reads the current value of <c>net.visdebug</c>.</summary>
    public static NetVisdebugCommand CreateGet()
    {
        var cmd = CreatePackage<NetVisdebugCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>net.visdebug</c> to <paramref name="value"/>.</summary>
    public static NetVisdebugCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<NetVisdebugCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
