using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.tick_max_distance</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.tick_max_distance</c></remarks>
public sealed class AntihackTickMaxDistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.tick_max_distance";

    /// <summary>Reads the current value of <c>antihack.tick_max_distance</c>.</summary>
    public static AntihackTickMaxDistanceCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTickMaxDistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.tick_max_distance</c> to <paramref name="value"/>.</summary>
    public static AntihackTickMaxDistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackTickMaxDistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
