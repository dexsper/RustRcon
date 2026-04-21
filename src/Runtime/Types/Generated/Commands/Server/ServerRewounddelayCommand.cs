using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum seconds that must pass after a player recovers from being wounded before they can be put into the wounded state again</summary>
/// <remarks>Full RCON name: <c>server.rewounddelay</c></remarks>
public sealed class ServerRewounddelayCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.rewounddelay";

    /// <summary>Reads the current value of <c>server.rewounddelay</c>.</summary>
    public static ServerRewounddelayCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRewounddelayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.rewounddelay</c> to <paramref name="value"/>.</summary>
    public static ServerRewounddelayCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerRewounddelayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
