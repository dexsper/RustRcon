using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.noclip_penalty</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.noclip_penalty</c></remarks>
public sealed class AntihackNoclipPenaltyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.noclip_penalty";

    /// <summary>Reads the current value of <c>antihack.noclip_penalty</c>.</summary>
    public static AntihackNoclipPenaltyCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackNoclipPenaltyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.noclip_penalty</c> to <paramref name="value"/>.</summary>
    public static AntihackNoclipPenaltyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackNoclipPenaltyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
