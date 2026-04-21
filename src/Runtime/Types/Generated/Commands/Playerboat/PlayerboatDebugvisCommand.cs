using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, draws debug visualisations for player boat state including drift target, shore direction, and power zones</summary>
/// <remarks>Full RCON name: <c>playerboat.debugvis</c></remarks>
public sealed class PlayerboatDebugvisCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.debugvis";

    /// <summary>Reads the current value of <c>playerboat.debugvis</c>.</summary>
    public static PlayerboatDebugvisCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatDebugvisCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.debugvis</c> to <paramref name="value"/>.</summary>
    public static PlayerboatDebugvisCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerboatDebugvisCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
