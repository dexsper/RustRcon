using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, player boat engines are powered down when no players are aboard; prevents runaway unmanned boats</summary>
/// <remarks>Full RCON name: <c>playerboat.powerdownonnoplayers</c></remarks>
public sealed class PlayerboatPowerdownonnoplayersCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.powerdownonnoplayers";

    /// <summary>Reads the current value of <c>playerboat.powerdownonnoplayers</c>.</summary>
    public static PlayerboatPowerdownonnoplayersCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatPowerdownonnoplayersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.powerdownonnoplayers</c> to <paramref name="value"/>.</summary>
    public static PlayerboatPowerdownonnoplayersCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerboatPowerdownonnoplayersCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
