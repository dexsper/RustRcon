using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ridablehorse.dungtimescale</c>.</summary>
/// <remarks>Full RCON name: <c>ridablehorse.dungtimescale</c></remarks>
public sealed class RidablehorseDungtimescaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ridablehorse.dungtimescale";

    /// <summary>Reads the current value of <c>ridablehorse.dungtimescale</c>.</summary>
    public static RidablehorseDungtimescaleCommand CreateGet()
    {
        var cmd = CreatePackage<RidablehorseDungtimescaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ridablehorse.dungtimescale</c> to <paramref name="value"/>.</summary>
    public static RidablehorseDungtimescaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<RidablehorseDungtimescaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
