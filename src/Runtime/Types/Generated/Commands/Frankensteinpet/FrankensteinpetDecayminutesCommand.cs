using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a Frankenstein Pet dies un controlled and not asleep on table</summary>
/// <remarks>Full RCON name: <c>frankensteinpet.decayminutes</c></remarks>
public sealed class FrankensteinpetDecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "frankensteinpet.decayminutes";

    /// <summary>Reads the current value of <c>frankensteinpet.decayminutes</c>.</summary>
    public static FrankensteinpetDecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<FrankensteinpetDecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>frankensteinpet.decayminutes</c> to <paramref name="value"/>.</summary>
    public static FrankensteinpetDecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<FrankensteinpetDecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
