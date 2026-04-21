using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Puts the specified player into the wounded/downed state immediately without killing them; useful for testing the crawl/revive mechanics</summary>
/// <remarks>Full RCON name: <c>global.injureplayer</c></remarks>
public sealed class GlobalInjureplayerCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.injureplayer";

    /// <summary>Creates a new <see cref="GlobalInjureplayerCommand"/> command.</summary>
    public static GlobalInjureplayerCommand Create(string args)
    {
        var cmd = CreatePackage<GlobalInjureplayerCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
