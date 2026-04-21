using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.build_losradius_sleepingbag</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.build_losradius_sleepingbag</c></remarks>
public sealed class AntihackBuildLosradiusSleepingbagCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.build_losradius_sleepingbag";

    /// <summary>Reads the current value of <c>antihack.build_losradius_sleepingbag</c>.</summary>
    public static AntihackBuildLosradiusSleepingbagCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackBuildLosradiusSleepingbagCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.build_losradius_sleepingbag</c> to <paramref name="value"/>.</summary>
    public static AntihackBuildLosradiusSleepingbagCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackBuildLosradiusSleepingbagCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
