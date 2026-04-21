using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.melee_penalty</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.melee_penalty</c></remarks>
public sealed class AntihackMeleePenaltyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.melee_penalty";

    /// <summary>Reads the current value of <c>antihack.melee_penalty</c>.</summary>
    public static AntihackMeleePenaltyCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMeleePenaltyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.melee_penalty</c> to <paramref name="value"/>.</summary>
    public static AntihackMeleePenaltyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackMeleePenaltyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
