using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.flyhack_penalty</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.flyhack_penalty</c></remarks>
public sealed class AntihackFlyhackPenaltyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.flyhack_penalty";

    /// <summary>Reads the current value of <c>antihack.flyhack_penalty</c>.</summary>
    public static AntihackFlyhackPenaltyCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackFlyhackPenaltyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.flyhack_penalty</c> to <paramref name="value"/>.</summary>
    public static AntihackFlyhackPenaltyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackFlyhackPenaltyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
