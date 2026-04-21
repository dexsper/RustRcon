using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Multiplier applied to all bullet damage dealt by the patrol helicopter; 1.0 = normal, 2.0 = double damage</summary>
/// <remarks>Full RCON name: <c>heli.bulletdamagescale</c></remarks>
public sealed class HeliBulletdamagescaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "heli.bulletdamagescale";

    /// <summary>Reads the current value of <c>heli.bulletdamagescale</c>.</summary>
    public static HeliBulletdamagescaleCommand CreateGet()
    {
        var cmd = CreatePackage<HeliBulletdamagescaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>heli.bulletdamagescale</c> to <paramref name="value"/>.</summary>
    public static HeliBulletdamagescaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HeliBulletdamagescaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
