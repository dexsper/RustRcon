using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Un/Subscribes the current RCON connection to changes in server state. This could be a performance hit and should only be used if you need it.</summary>
/// <remarks>Full RCON name: <c>rcon.subscribe</c></remarks>
public sealed class RconSubscribeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.subscribe";

    /// <summary>Creates a new <see cref="RconSubscribeCommand"/> command.</summary>
    public static RconSubscribeCommand Create()
    {
        var cmd = CreatePackage<RconSubscribeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
