using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>fishing.debugoverfishing</c>.</summary>
/// <remarks>Full RCON name: <c>fishing.debugoverfishing</c></remarks>
public sealed class FishingDebugoverfishingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "fishing.debugoverfishing";

    /// <summary>Reads the current value of <c>fishing.debugoverfishing</c>.</summary>
    public static FishingDebugoverfishingCommand CreateGet()
    {
        var cmd = CreatePackage<FishingDebugoverfishingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>fishing.debugoverfishing</c> to <paramref name="value"/>.</summary>
    public static FishingDebugoverfishingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<FishingDebugoverfishingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
