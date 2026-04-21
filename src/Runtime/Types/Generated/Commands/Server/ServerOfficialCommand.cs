using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Marks this as an official Facepunch server; only set by Facepunch — do not enable on community servers</summary>
/// <remarks>Full RCON name: <c>server.official</c></remarks>
public sealed class ServerOfficialCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.official";

    /// <summary>Reads the current value of <c>server.official</c>.</summary>
    public static ServerOfficialCommand CreateGet()
    {
        var cmd = CreatePackage<ServerOfficialCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.official</c> to <paramref name="value"/>.</summary>
    public static ServerOfficialCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerOfficialCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
