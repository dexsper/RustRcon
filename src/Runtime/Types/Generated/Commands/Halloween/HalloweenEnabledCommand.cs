using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables the Halloween event on the server, activating Halloween-themed loot spawns, NPC variants, and event-specific mechanics</summary>
/// <remarks>Full RCON name: <c>halloween.enabled</c></remarks>
public sealed class HalloweenEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "halloween.enabled";

    /// <summary>Reads the current value of <c>halloween.enabled</c>.</summary>
    public static HalloweenEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<HalloweenEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>halloween.enabled</c> to <paramref name="value"/>.</summary>
    public static HalloweenEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<HalloweenEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
