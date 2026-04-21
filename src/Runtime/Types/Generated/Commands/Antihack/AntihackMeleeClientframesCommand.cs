using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.melee_clientframes</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.melee_clientframes</c></remarks>
public sealed class AntihackMeleeClientframesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.melee_clientframes";

    /// <summary>Reads the current value of <c>antihack.melee_clientframes</c>.</summary>
    public static AntihackMeleeClientframesCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMeleeClientframesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.melee_clientframes</c> to <paramref name="value"/>.</summary>
    public static AntihackMeleeClientframesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackMeleeClientframesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
