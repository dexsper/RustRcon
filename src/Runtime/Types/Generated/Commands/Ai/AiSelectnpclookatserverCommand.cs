using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Editor-only: finds the NPC entity with the given network ID on the server and selects its game object in the Unity editor hierarchy</summary>
/// <remarks>Full RCON name: <c>ai.selectnpclookatserver</c></remarks>
public sealed class AiSelectnpclookatserverCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.selectnpclookatserver";

    /// <summary>Creates a new <see cref="AiSelectnpclookatserverCommand"/> command.</summary>
    public static AiSelectnpclookatserverCommand Create()
    {
        var cmd = CreatePackage<AiSelectnpclookatserverCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
