using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.noclip_maxsteps</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.noclip_maxsteps</c></remarks>
public sealed class AntihackNoclipMaxstepsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.noclip_maxsteps";

    /// <summary>Reads the current value of <c>antihack.noclip_maxsteps</c>.</summary>
    public static AntihackNoclipMaxstepsCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackNoclipMaxstepsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.noclip_maxsteps</c> to <paramref name="value"/>.</summary>
    public static AntihackNoclipMaxstepsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackNoclipMaxstepsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
