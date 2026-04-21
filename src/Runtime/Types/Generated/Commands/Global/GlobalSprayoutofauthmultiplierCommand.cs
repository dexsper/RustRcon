using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Multiplier applied to SprayDuration if a spray isn't in the sprayers auth (cannot go above 1f)</summary>
/// <remarks>Full RCON name: <c>global.sprayoutofauthmultiplier</c></remarks>
public sealed class GlobalSprayoutofauthmultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.sprayoutofauthmultiplier";

    /// <summary>Reads the current value of <c>global.sprayoutofauthmultiplier</c>.</summary>
    public static GlobalSprayoutofauthmultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSprayoutofauthmultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.sprayoutofauthmultiplier</c> to <paramref name="value"/>.</summary>
    public static GlobalSprayoutofauthmultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<GlobalSprayoutofauthmultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
