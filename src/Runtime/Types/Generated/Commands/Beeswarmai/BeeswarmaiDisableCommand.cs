using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>beeswarmai.disable</c>.</summary>
/// <remarks>Full RCON name: <c>beeswarmai.disable</c></remarks>
public sealed class BeeswarmaiDisableCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beeswarmai.disable";

    /// <summary>Reads the current value of <c>beeswarmai.disable</c>.</summary>
    public static BeeswarmaiDisableCommand CreateGet()
    {
        var cmd = CreatePackage<BeeswarmaiDisableCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beeswarmai.disable</c> to <paramref name="value"/>.</summary>
    public static BeeswarmaiDisableCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BeeswarmaiDisableCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
