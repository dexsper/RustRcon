using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vis.attack</c>.</summary>
/// <remarks>Full RCON name: <c>vis.attack</c></remarks>
public sealed class VisAttackCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vis.attack";

    /// <summary>Reads the current value of <c>vis.attack</c>.</summary>
    public static VisAttackCommand CreateGet()
    {
        var cmd = CreatePackage<VisAttackCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vis.attack</c> to <paramref name="value"/>.</summary>
    public static VisAttackCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VisAttackCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
