using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>sail.maxthrustmultiplier</c>.</summary>
/// <remarks>Full RCON name: <c>sail.maxthrustmultiplier</c></remarks>
public sealed class SailMaxthrustmultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sail.maxthrustmultiplier";

    /// <summary>Reads the current value of <c>sail.maxthrustmultiplier</c>.</summary>
    public static SailMaxthrustmultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<SailMaxthrustmultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>sail.maxthrustmultiplier</c> to <paramref name="value"/>.</summary>
    public static SailMaxthrustmultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SailMaxthrustmultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
