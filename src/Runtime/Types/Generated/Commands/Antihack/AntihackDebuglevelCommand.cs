using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.debuglevel</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.debuglevel</c></remarks>
public sealed class AntihackDebuglevelCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.debuglevel";

    /// <summary>Reads the current value of <c>antihack.debuglevel</c>.</summary>
    public static AntihackDebuglevelCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackDebuglevelCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.debuglevel</c> to <paramref name="value"/>.</summary>
    public static AntihackDebuglevelCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackDebuglevelCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
