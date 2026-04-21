using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, chat warnings are broadcast to players inside a monument shortly before its puzzle-reset radiation begins</summary>
/// <remarks>Full RCON name: <c>server.monumentpuzzleresetwarnings</c></remarks>
public sealed class ServerMonumentpuzzleresetwarningsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.monumentpuzzleresetwarnings";

    /// <summary>Reads the current value of <c>server.monumentpuzzleresetwarnings</c>.</summary>
    public static ServerMonumentpuzzleresetwarningsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetwarningsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.monumentpuzzleresetwarnings</c> to <paramref name="value"/>.</summary>
    public static ServerMonumentpuzzleresetwarningsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetwarningsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
