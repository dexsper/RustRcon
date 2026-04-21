using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>0 - 1</summary>
/// <remarks>Full RCON name: <c>playerboat.enginepositioninfluences</c></remarks>
public sealed class PlayerboatEnginepositioninfluencesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.enginepositioninfluences";

    /// <summary>Reads the current value of <c>playerboat.enginepositioninfluences</c>.</summary>
    public static PlayerboatEnginepositioninfluencesCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatEnginepositioninfluencesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.enginepositioninfluences</c> to <paramref name="value"/>.</summary>
    public static PlayerboatEnginepositioninfluencesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerboatEnginepositioninfluencesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
