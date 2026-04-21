using RustRcon.Types;
using RustRcon.Types.Commands.Base;
using RustRcon.Generated.Dtos;

namespace RustRcon.Generated.Commands;

/// <summary>Get a list of information about the server</summary>
/// <remarks>Full RCON name: <c>global.serverinfo</c></remarks>
public sealed class GlobalServerinfoCommand : BaseCallCommand<ServerInfoOutput>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.serverinfo";

    /// <summary>Creates a new <see cref="GlobalServerinfoCommand"/> command.</summary>
    public static GlobalServerinfoCommand Create()
    {
        var cmd = CreatePackage<GlobalServerinfoCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
