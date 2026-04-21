using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>baseboat.drift_speed</c>.</summary>
/// <remarks>Full RCON name: <c>baseboat.drift_speed</c></remarks>
public sealed class BaseboatDriftSpeedCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "baseboat.drift_speed";

    /// <summary>Reads the current value of <c>baseboat.drift_speed</c>.</summary>
    public static BaseboatDriftSpeedCommand CreateGet()
    {
        var cmd = CreatePackage<BaseboatDriftSpeedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>baseboat.drift_speed</c> to <paramref name="value"/>.</summary>
    public static BaseboatDriftSpeedCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BaseboatDriftSpeedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
