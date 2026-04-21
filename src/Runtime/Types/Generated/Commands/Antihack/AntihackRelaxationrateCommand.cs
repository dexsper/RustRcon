using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.relaxationrate</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.relaxationrate</c></remarks>
public sealed class AntihackRelaxationrateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.relaxationrate";

    /// <summary>Reads the current value of <c>antihack.relaxationrate</c>.</summary>
    public static AntihackRelaxationrateCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackRelaxationrateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.relaxationrate</c> to <paramref name="value"/>.</summary>
    public static AntihackRelaxationrateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackRelaxationrateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
