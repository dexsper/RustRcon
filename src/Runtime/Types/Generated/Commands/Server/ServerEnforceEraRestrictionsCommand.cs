using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Deletes items on the server that are not allowed in the era</summary>
/// <remarks>Full RCON name: <c>server.enforce_era_restrictions</c></remarks>
public sealed class ServerEnforceEraRestrictionsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.enforce_era_restrictions";

    /// <summary>Creates a new <see cref="ServerEnforceEraRestrictionsCommand"/> command.</summary>
    public static ServerEnforceEraRestrictionsCommand Create()
    {
        var cmd = CreatePackage<ServerEnforceEraRestrictionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
