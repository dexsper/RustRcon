using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Disables the backpacks that appear after a corpse times out</summary>
/// <remarks>Full RCON name: <c>global.disablebagdropping</c></remarks>
public sealed class GlobalDisablebagdroppingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.disablebagdropping";

    /// <summary>Reads the current value of <c>global.disablebagdropping</c>.</summary>
    public static GlobalDisablebagdroppingCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalDisablebagdroppingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.disablebagdropping</c> to <paramref name="value"/>.</summary>
    public static GlobalDisablebagdroppingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<GlobalDisablebagdroppingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
