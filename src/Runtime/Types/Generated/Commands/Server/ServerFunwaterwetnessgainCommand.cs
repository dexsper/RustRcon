using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>server.funwaterwetnessgain</c>.</summary>
/// <remarks>Full RCON name: <c>server.funwaterwetnessgain</c></remarks>
public sealed class ServerFunwaterwetnessgainCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.funwaterwetnessgain";

    /// <summary>Reads the current value of <c>server.funwaterwetnessgain</c>.</summary>
    public static ServerFunwaterwetnessgainCommand CreateGet()
    {
        var cmd = CreatePackage<ServerFunwaterwetnessgainCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.funwaterwetnessgain</c> to <paramref name="value"/>.</summary>
    public static ServerFunwaterwetnessgainCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerFunwaterwetnessgainCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
