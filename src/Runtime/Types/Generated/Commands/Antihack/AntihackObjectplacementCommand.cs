using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.objectplacement</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.objectplacement</c></remarks>
public sealed class AntihackObjectplacementCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.objectplacement";

    /// <summary>Reads the current value of <c>antihack.objectplacement</c>.</summary>
    public static AntihackObjectplacementCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackObjectplacementCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.objectplacement</c> to <paramref name="value"/>.</summary>
    public static AntihackObjectplacementCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackObjectplacementCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
