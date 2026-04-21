using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Toggles the usage of mountable MountedPlayerSync optimisations (only used by boat scientists currently)</summary>
/// <remarks>Full RCON name: <c>basemountable.canpausemountedplayersync</c></remarks>
public sealed class BasemountableCanpausemountedplayersyncCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basemountable.canpausemountedplayersync";

    /// <summary>Reads the current value of <c>basemountable.canpausemountedplayersync</c>.</summary>
    public static BasemountableCanpausemountedplayersyncCommand CreateGet()
    {
        var cmd = CreatePackage<BasemountableCanpausemountedplayersyncCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basemountable.canpausemountedplayersync</c> to <paramref name="value"/>.</summary>
    public static BasemountableCanpausemountedplayersyncCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BasemountableCanpausemountedplayersyncCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
