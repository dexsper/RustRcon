using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.speedhack_penalty</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.speedhack_penalty</c></remarks>
public sealed class AntihackSpeedhackPenaltyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.speedhack_penalty";

    /// <summary>Reads the current value of <c>antihack.speedhack_penalty</c>.</summary>
    public static AntihackSpeedhackPenaltyCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackSpeedhackPenaltyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.speedhack_penalty</c> to <paramref name="value"/>.</summary>
    public static AntihackSpeedhackPenaltyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackSpeedhackPenaltyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
