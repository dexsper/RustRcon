using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>0 - 1</summary>
/// <remarks>Full RCON name: <c>playerboat.sailpositioninfluence</c></remarks>
public sealed class PlayerboatSailpositioninfluenceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.sailpositioninfluence";

    /// <summary>Reads the current value of <c>playerboat.sailpositioninfluence</c>.</summary>
    public static PlayerboatSailpositioninfluenceCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatSailpositioninfluenceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.sailpositioninfluence</c> to <paramref name="value"/>.</summary>
    public static PlayerboatSailpositioninfluenceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerboatSailpositioninfluenceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
