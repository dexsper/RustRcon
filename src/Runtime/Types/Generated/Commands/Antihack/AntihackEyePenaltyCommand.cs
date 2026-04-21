using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_penalty</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_penalty</c></remarks>
public sealed class AntihackEyePenaltyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_penalty";

    /// <summary>Reads the current value of <c>antihack.eye_penalty</c>.</summary>
    public static AntihackEyePenaltyCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyePenaltyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_penalty</c> to <paramref name="value"/>.</summary>
    public static AntihackEyePenaltyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackEyePenaltyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
