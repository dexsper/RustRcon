using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Seed value used for procedural world generation; changing this produces a completely different map layout</summary>
/// <remarks>Full RCON name: <c>server.seed</c></remarks>
public sealed class ServerSeedCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.seed";

    /// <summary>Reads the current value of <c>server.seed</c>.</summary>
    public static ServerSeedCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSeedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.seed</c> to <paramref name="value"/>.</summary>
    public static ServerSeedCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerSeedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
