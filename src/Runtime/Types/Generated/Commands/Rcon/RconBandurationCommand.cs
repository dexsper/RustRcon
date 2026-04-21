using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long in seconds to ban an IP that has exceeded the maximum password failures (default: 300 seconds)</summary>
/// <remarks>Full RCON name: <c>rcon.banduration</c></remarks>
public sealed class RconBandurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.banduration";

    /// <summary>Reads the current value of <c>rcon.banduration</c>.</summary>
    public static RconBandurationCommand CreateGet()
    {
        var cmd = CreatePackage<RconBandurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.banduration</c> to <paramref name="value"/>.</summary>
    public static RconBandurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<RconBandurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
