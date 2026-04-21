using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.tickhistoryforgiveness</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.tickhistoryforgiveness</c></remarks>
public sealed class AntihackTickhistoryforgivenessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.tickhistoryforgiveness";

    /// <summary>Reads the current value of <c>antihack.tickhistoryforgiveness</c>.</summary>
    public static AntihackTickhistoryforgivenessCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTickhistoryforgivenessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.tickhistoryforgiveness</c> to <paramref name="value"/>.</summary>
    public static AntihackTickhistoryforgivenessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackTickhistoryforgivenessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
