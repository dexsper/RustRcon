using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vis.protection</c>.</summary>
/// <remarks>Full RCON name: <c>vis.protection</c></remarks>
public sealed class VisProtectionCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vis.protection";

    /// <summary>Reads the current value of <c>vis.protection</c>.</summary>
    public static VisProtectionCommand CreateGet()
    {
        var cmd = CreatePackage<VisProtectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vis.protection</c> to <paramref name="value"/>.</summary>
    public static VisProtectionCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VisProtectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
