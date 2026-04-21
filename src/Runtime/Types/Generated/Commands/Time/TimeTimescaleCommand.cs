using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>time.timescale</c>.</summary>
/// <remarks>Full RCON name: <c>time.timescale</c></remarks>
public sealed class TimeTimescaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "time.timescale";

    /// <summary>Reads the current value of <c>time.timescale</c>.</summary>
    public static TimeTimescaleCommand CreateGet()
    {
        var cmd = CreatePackage<TimeTimescaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>time.timescale</c> to <paramref name="value"/>.</summary>
    public static TimeTimescaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TimeTimescaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
