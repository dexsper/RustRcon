using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The collision detection mode that dropped items and corpses should use</summary>
/// <remarks>Full RCON name: <c>physics.droppedmode</c></remarks>
public sealed class PhysicsDroppedmodeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.droppedmode";

    /// <summary>Reads the current value of <c>physics.droppedmode</c>.</summary>
    public static PhysicsDroppedmodeCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsDroppedmodeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.droppedmode</c> to <paramref name="value"/>.</summary>
    public static PhysicsDroppedmodeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PhysicsDroppedmodeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
