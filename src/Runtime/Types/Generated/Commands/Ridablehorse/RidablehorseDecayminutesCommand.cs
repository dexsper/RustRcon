using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a horse dies unattended</summary>
/// <remarks>Full RCON name: <c>ridablehorse.decayminutes</c></remarks>
public sealed class RidablehorseDecayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ridablehorse.decayminutes";

    /// <summary>Reads the current value of <c>ridablehorse.decayminutes</c>.</summary>
    public static RidablehorseDecayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<RidablehorseDecayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ridablehorse.decayminutes</c> to <paramref name="value"/>.</summary>
    public static RidablehorseDecayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<RidablehorseDecayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
