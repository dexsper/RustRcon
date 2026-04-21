using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>[0.0 to 1.0]</summary>
/// <remarks>Full RCON name: <c>burieditems.buryitemchance</c></remarks>
public sealed class BurieditemsBuryitemchanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "burieditems.buryitemchance";

    /// <summary>Reads the current value of <c>burieditems.buryitemchance</c>.</summary>
    public static BurieditemsBuryitemchanceCommand CreateGet()
    {
        var cmd = CreatePackage<BurieditemsBuryitemchanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>burieditems.buryitemchance</c> to <paramref name="value"/>.</summary>
    public static BurieditemsBuryitemchanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BurieditemsBuryitemchanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
