using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.melee_serverframes</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.melee_serverframes</c></remarks>
public sealed class AntihackMeleeServerframesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.melee_serverframes";

    /// <summary>Reads the current value of <c>antihack.melee_serverframes</c>.</summary>
    public static AntihackMeleeServerframesCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMeleeServerframesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.melee_serverframes</c> to <paramref name="value"/>.</summary>
    public static AntihackMeleeServerframesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackMeleeServerframesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
