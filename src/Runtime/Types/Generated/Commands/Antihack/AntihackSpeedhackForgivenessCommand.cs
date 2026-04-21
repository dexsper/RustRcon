using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.speedhack_forgiveness</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.speedhack_forgiveness</c></remarks>
public sealed class AntihackSpeedhackForgivenessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.speedhack_forgiveness";

    /// <summary>Reads the current value of <c>antihack.speedhack_forgiveness</c>.</summary>
    public static AntihackSpeedhackForgivenessCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackSpeedhackForgivenessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.speedhack_forgiveness</c> to <paramref name="value"/>.</summary>
    public static AntihackSpeedhackForgivenessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackSpeedhackForgivenessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
