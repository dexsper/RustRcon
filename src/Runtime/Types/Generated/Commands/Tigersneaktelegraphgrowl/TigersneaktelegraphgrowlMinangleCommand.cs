using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Minimum angle for the tiger to growl when stalking a player</summary>
/// <remarks>Full RCON name: <c>tigersneaktelegraphgrowl.minangle</c></remarks>
public sealed class TigersneaktelegraphgrowlMinangleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tigersneaktelegraphgrowl.minangle";

    /// <summary>Reads the current value of <c>tigersneaktelegraphgrowl.minangle</c>.</summary>
    public static TigersneaktelegraphgrowlMinangleCommand CreateGet()
    {
        var cmd = CreatePackage<TigersneaktelegraphgrowlMinangleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tigersneaktelegraphgrowl.minangle</c> to <paramref name="value"/>.</summary>
    public static TigersneaktelegraphgrowlMinangleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TigersneaktelegraphgrowlMinangleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
