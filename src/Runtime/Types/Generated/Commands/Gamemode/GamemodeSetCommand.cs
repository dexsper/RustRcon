using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sets the active game mode by name; game modes can alter loot tables, rules, and player abilities (e.g. softcore, hardcore)</summary>
/// <remarks>Full RCON name: <c>gamemode.set</c></remarks>
public sealed class GamemodeSetCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gamemode.set";

    /// <summary>Creates a new <see cref="GamemodeSetCommand"/> command.</summary>
    public static GamemodeSetCommand Create(string args)
    {
        var cmd = CreatePackage<GamemodeSetCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
