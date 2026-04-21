using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many stacks a single conveyor can move in a single tick</summary>
/// <remarks>Full RCON name: <c>server.maxitemstacksmovedpertickindustrial</c></remarks>
public sealed class ServerMaxitemstacksmovedpertickindustrialCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxitemstacksmovedpertickindustrial";

    /// <summary>Reads the current value of <c>server.maxitemstacksmovedpertickindustrial</c>.</summary>
    public static ServerMaxitemstacksmovedpertickindustrialCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxitemstacksmovedpertickindustrialCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxitemstacksmovedpertickindustrial</c> to <paramref name="value"/>.</summary>
    public static ServerMaxitemstacksmovedpertickindustrialCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxitemstacksmovedpertickindustrialCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
