using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Clears all subscribers from the server.</summary>
/// <remarks>Full RCON name: <c>rcon.clear_subscribers</c></remarks>
public sealed class RconClearSubscribersCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.clear_subscribers";

    /// <summary>Creates a new <see cref="RconClearSubscribersCommand"/> command.</summary>
    public static RconClearSubscribersCommand Create()
    {
        var cmd = CreatePackage<RconClearSubscribersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
