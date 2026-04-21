using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>metaldetectorsource.attemptspersubsourcespawn</c>.</summary>
/// <remarks>Full RCON name: <c>metaldetectorsource.attemptspersubsourcespawn</c></remarks>
public sealed class MetaldetectorsourceAttemptspersubsourcespawnCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "metaldetectorsource.attemptspersubsourcespawn";

    /// <summary>Reads the current value of <c>metaldetectorsource.attemptspersubsourcespawn</c>.</summary>
    public static MetaldetectorsourceAttemptspersubsourcespawnCommand CreateGet()
    {
        var cmd = CreatePackage<MetaldetectorsourceAttemptspersubsourcespawnCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>metaldetectorsource.attemptspersubsourcespawn</c> to <paramref name="value"/>.</summary>
    public static MetaldetectorsourceAttemptspersubsourcespawnCommand CreateSet(int value)
    {
        var cmd = CreatePackage<MetaldetectorsourceAttemptspersubsourcespawnCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
