using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>smallengine.maxthrustmultiplier</c>.</summary>
/// <remarks>Full RCON name: <c>smallengine.maxthrustmultiplier</c></remarks>
public sealed class SmallengineMaxthrustmultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "smallengine.maxthrustmultiplier";

    /// <summary>Reads the current value of <c>smallengine.maxthrustmultiplier</c>.</summary>
    public static SmallengineMaxthrustmultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<SmallengineMaxthrustmultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>smallengine.maxthrustmultiplier</c> to <paramref name="value"/>.</summary>
    public static SmallengineMaxthrustmultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SmallengineMaxthrustmultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
