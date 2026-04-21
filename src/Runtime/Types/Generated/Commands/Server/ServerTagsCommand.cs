using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Comma-separated server browser tag values (see wiki)</summary>
/// <remarks>Full RCON name: <c>server.tags</c></remarks>
public sealed class ServerTagsCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.tags";

    /// <summary>Reads the current value of <c>server.tags</c>.</summary>
    public static ServerTagsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerTagsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.tags</c> to <paramref name="value"/>.</summary>
    public static ServerTagsCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerTagsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
