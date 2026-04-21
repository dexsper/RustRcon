using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>playerboat.usedestructiblewreckstability</c>.</summary>
/// <remarks>Full RCON name: <c>playerboat.usedestructiblewreckstability</c></remarks>
public sealed class PlayerboatUsedestructiblewreckstabilityCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.usedestructiblewreckstability";

    /// <summary>Reads the current value of <c>playerboat.usedestructiblewreckstability</c>.</summary>
    public static PlayerboatUsedestructiblewreckstabilityCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatUsedestructiblewreckstabilityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.usedestructiblewreckstability</c> to <paramref name="value"/>.</summary>
    public static PlayerboatUsedestructiblewreckstabilityCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerboatUsedestructiblewreckstabilityCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
