using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How often industrial conveyors attempt to move items (value is an interval measured in seconds). Setting to 0 will disable all movement</summary>
/// <remarks>Full RCON name: <c>server.conveyormovefrequency</c></remarks>
public sealed class ServerConveyormovefrequencyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.conveyormovefrequency";

    /// <summary>Reads the current value of <c>server.conveyormovefrequency</c>.</summary>
    public static ServerConveyormovefrequencyCommand CreateGet()
    {
        var cmd = CreatePackage<ServerConveyormovefrequencyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.conveyormovefrequency</c> to <paramref name="value"/>.</summary>
    public static ServerConveyormovefrequencyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerConveyormovefrequencyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
