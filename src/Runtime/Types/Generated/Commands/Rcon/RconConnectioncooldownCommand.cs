using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long (in seconds) before we allow another rcon connection from the same address (default: 1 second)</summary>
/// <remarks>Full RCON name: <c>rcon.connectioncooldown</c></remarks>
public sealed class RconConnectioncooldownCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.connectioncooldown";

    /// <summary>Reads the current value of <c>rcon.connectioncooldown</c>.</summary>
    public static RconConnectioncooldownCommand CreateGet()
    {
        var cmd = CreatePackage<RconConnectioncooldownCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.connectioncooldown</c> to <paramref name="value"/>.</summary>
    public static RconConnectioncooldownCommand CreateSet(float value)
    {
        var cmd = CreatePackage<RconConnectioncooldownCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
