using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>banid &lt;steamid&gt; &lt;username&gt; &lt;reason&gt; [optional duration]</summary>
/// <remarks>Full RCON name: <c>global.banid</c></remarks>
public sealed class GlobalBanidCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.banid";

    /// <summary>Creates a new <see cref="GlobalBanidCommand"/> command.</summary>
    public static GlobalBanidCommand Create(SteamId steamId, string text, string arg2)
    {
        var cmd = CreatePackage<GlobalBanidCommand>();
        cmd.Content = $"{CommandFullName} {steamId} {text} {arg2}";
        return cmd;
    }
}
