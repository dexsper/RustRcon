using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>When enabled a player wearing a gingerbread suit will gib like the gingerbread NPC's</summary>
/// <remarks>Full RCON name: <c>global.cinematicgingerbreadcorpses</c></remarks>
public sealed class GlobalCinematicgingerbreadcorpsesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.cinematicgingerbreadcorpses";

    /// <summary>Reads the current value of <c>global.cinematicgingerbreadcorpses</c>.</summary>
    public static GlobalCinematicgingerbreadcorpsesCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalCinematicgingerbreadcorpsesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.cinematicgingerbreadcorpses</c> to <paramref name="value"/>.</summary>
    public static GlobalCinematicgingerbreadcorpsesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<GlobalCinematicgingerbreadcorpsesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
