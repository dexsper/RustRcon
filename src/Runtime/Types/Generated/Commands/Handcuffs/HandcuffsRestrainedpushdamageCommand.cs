using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Damage dealt to a restrained (handcuffed) player when they attempt to push or escape; default 5</summary>
/// <remarks>Full RCON name: <c>handcuffs.restrainedpushdamage</c></remarks>
public sealed class HandcuffsRestrainedpushdamageCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "handcuffs.restrainedpushdamage";

    /// <summary>Reads the current value of <c>handcuffs.restrainedpushdamage</c>.</summary>
    public static HandcuffsRestrainedpushdamageCommand CreateGet()
    {
        var cmd = CreatePackage<HandcuffsRestrainedpushdamageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>handcuffs.restrainedpushdamage</c> to <paramref name="value"/>.</summary>
    public static HandcuffsRestrainedpushdamageCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HandcuffsRestrainedpushdamageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
