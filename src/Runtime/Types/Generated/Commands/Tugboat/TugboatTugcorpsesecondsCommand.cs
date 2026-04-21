using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>tugboat.tugcorpseseconds</c>.</summary>
/// <remarks>Full RCON name: <c>tugboat.tugcorpseseconds</c></remarks>
public sealed class TugboatTugcorpsesecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tugboat.tugcorpseseconds";

    /// <summary>Reads the current value of <c>tugboat.tugcorpseseconds</c>.</summary>
    public static TugboatTugcorpsesecondsCommand CreateGet()
    {
        var cmd = CreatePackage<TugboatTugcorpsesecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tugboat.tugcorpseseconds</c> to <paramref name="value"/>.</summary>
    public static TugboatTugcorpsesecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TugboatTugcorpsesecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
