using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Send effects to clients when physics objects collide</summary>
/// <remarks>Full RCON name: <c>physics.sendeffects</c></remarks>
public sealed class PhysicsSendeffectsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.sendeffects";

    /// <summary>Reads the current value of <c>physics.sendeffects</c>.</summary>
    public static PhysicsSendeffectsCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsSendeffectsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.sendeffects</c> to <paramref name="value"/>.</summary>
    public static PhysicsSendeffectsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PhysicsSendeffectsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
