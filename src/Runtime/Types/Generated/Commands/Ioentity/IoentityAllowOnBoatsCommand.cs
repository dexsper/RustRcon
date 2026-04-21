using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Allows the deployment and usage of IO entities on player boats and tugboats.</summary>
/// <remarks>Full RCON name: <c>ioentity.allow_on_boats</c></remarks>
public sealed class IoentityAllowOnBoatsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.allow_on_boats";

    /// <summary>Reads the current value of <c>ioentity.allow_on_boats</c>.</summary>
    public static IoentityAllowOnBoatsCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityAllowOnBoatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.allow_on_boats</c> to <paramref name="value"/>.</summary>
    public static IoentityAllowOnBoatsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<IoentityAllowOnBoatsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
