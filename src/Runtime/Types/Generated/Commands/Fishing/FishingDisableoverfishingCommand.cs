using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>fishing.disableoverfishing</c>.</summary>
/// <remarks>Full RCON name: <c>fishing.disableoverfishing</c></remarks>
public sealed class FishingDisableoverfishingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "fishing.disableoverfishing";

    /// <summary>Reads the current value of <c>fishing.disableoverfishing</c>.</summary>
    public static FishingDisableoverfishingCommand CreateGet()
    {
        var cmd = CreatePackage<FishingDisableoverfishingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>fishing.disableoverfishing</c> to <paramref name="value"/>.</summary>
    public static FishingDisableoverfishingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<FishingDisableoverfishingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
