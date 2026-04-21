using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>playerboat.velocitymax</c>.</summary>
/// <remarks>Full RCON name: <c>playerboat.velocitymax</c></remarks>
public sealed class PlayerboatVelocitymaxCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.velocitymax";

    /// <summary>Reads the current value of <c>playerboat.velocitymax</c>.</summary>
    public static PlayerboatVelocitymaxCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatVelocitymaxCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.velocitymax</c> to <paramref name="value"/>.</summary>
    public static PlayerboatVelocitymaxCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerboatVelocitymaxCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
