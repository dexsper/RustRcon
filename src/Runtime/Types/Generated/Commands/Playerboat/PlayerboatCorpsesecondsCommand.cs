using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>playerboat.corpseseconds</c>.</summary>
/// <remarks>Full RCON name: <c>playerboat.corpseseconds</c></remarks>
public sealed class PlayerboatCorpsesecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.corpseseconds";

    /// <summary>Reads the current value of <c>playerboat.corpseseconds</c>.</summary>
    public static PlayerboatCorpsesecondsCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatCorpsesecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.corpseseconds</c> to <paramref name="value"/>.</summary>
    public static PlayerboatCorpsesecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerboatCorpsesecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
