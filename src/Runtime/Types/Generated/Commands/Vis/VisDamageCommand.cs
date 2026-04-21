using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vis.damage</c>.</summary>
/// <remarks>Full RCON name: <c>vis.damage</c></remarks>
public sealed class VisDamageCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vis.damage";

    /// <summary>Reads the current value of <c>vis.damage</c>.</summary>
    public static VisDamageCommand CreateGet()
    {
        var cmd = CreatePackage<VisDamageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vis.damage</c> to <paramref name="value"/>.</summary>
    public static VisDamageCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VisDamageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
