using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.relaxationpause</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.relaxationpause</c></remarks>
public sealed class AntihackRelaxationpauseCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.relaxationpause";

    /// <summary>Reads the current value of <c>antihack.relaxationpause</c>.</summary>
    public static AntihackRelaxationpauseCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackRelaxationpauseCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.relaxationpause</c> to <paramref name="value"/>.</summary>
    public static AntihackRelaxationpauseCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackRelaxationpauseCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
