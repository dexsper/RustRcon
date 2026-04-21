using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Cone angle in degrees of the patrol helicopter gun spread; higher values make the helicopter less accurate</summary>
/// <remarks>Full RCON name: <c>heli.bulletaccuracy</c></remarks>
public sealed class HeliBulletaccuracyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "heli.bulletaccuracy";

    /// <summary>Reads the current value of <c>heli.bulletaccuracy</c>.</summary>
    public static HeliBulletaccuracyCommand CreateGet()
    {
        var cmd = CreatePackage<HeliBulletaccuracyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>heli.bulletaccuracy</c> to <paramref name="value"/>.</summary>
    public static HeliBulletaccuracyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HeliBulletaccuracyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
