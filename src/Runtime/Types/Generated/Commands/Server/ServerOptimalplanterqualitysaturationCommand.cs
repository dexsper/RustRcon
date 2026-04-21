using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Soil saturation level (0–1) at which a planter box is considered perfectly watered for quality bonuses; default 0.6</summary>
/// <remarks>Full RCON name: <c>server.optimalplanterqualitysaturation</c></remarks>
public sealed class ServerOptimalplanterqualitysaturationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.optimalplanterqualitysaturation";

    /// <summary>Reads the current value of <c>server.optimalplanterqualitysaturation</c>.</summary>
    public static ServerOptimalplanterqualitysaturationCommand CreateGet()
    {
        var cmd = CreatePackage<ServerOptimalplanterqualitysaturationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.optimalplanterqualitysaturation</c> to <paramref name="value"/>.</summary>
    public static ServerOptimalplanterqualitysaturationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerOptimalplanterqualitysaturationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
