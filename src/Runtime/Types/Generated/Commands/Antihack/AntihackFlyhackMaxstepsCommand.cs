using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.flyhack_maxsteps</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.flyhack_maxsteps</c></remarks>
public sealed class AntihackFlyhackMaxstepsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.flyhack_maxsteps";

    /// <summary>Reads the current value of <c>antihack.flyhack_maxsteps</c>.</summary>
    public static AntihackFlyhackMaxstepsCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackFlyhackMaxstepsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.flyhack_maxsteps</c> to <paramref name="value"/>.</summary>
    public static AntihackFlyhackMaxstepsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackFlyhackMaxstepsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
