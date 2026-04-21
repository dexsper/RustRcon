using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Enables a faster way to move items around during conveyor transfers. Should be on unless there's a issue</summary>
/// <remarks>Full RCON name: <c>server.industrialallowquickmove</c></remarks>
public sealed class ServerIndustrialallowquickmoveCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.industrialallowquickmove";

    /// <summary>Reads the current value of <c>server.industrialallowquickmove</c>.</summary>
    public static ServerIndustrialallowquickmoveCommand CreateGet()
    {
        var cmd = CreatePackage<ServerIndustrialallowquickmoveCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.industrialallowquickmove</c> to <paramref name="value"/>.</summary>
    public static ServerIndustrialallowquickmoveCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerIndustrialallowquickmoveCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
