using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Time in seconds after a boat is anchored before it becomes eligible for shore drift; default 21600s (6 hours)</summary>
/// <remarks>Full RCON name: <c>playerboat.anchoreddriftdelayseconds</c></remarks>
public sealed class PlayerboatAnchoreddriftdelaysecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.anchoreddriftdelayseconds";

    /// <summary>Reads the current value of <c>playerboat.anchoreddriftdelayseconds</c>.</summary>
    public static PlayerboatAnchoreddriftdelaysecondsCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatAnchoreddriftdelaysecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.anchoreddriftdelayseconds</c> to <paramref name="value"/>.</summary>
    public static PlayerboatAnchoreddriftdelaysecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerboatAnchoreddriftdelaysecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
