using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The collision detection mode that server-side ragdolls should use</summary>
/// <remarks>Full RCON name: <c>physics.serverragdollmode</c></remarks>
public sealed class PhysicsServerragdollmodeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.serverragdollmode";

    /// <summary>Reads the current value of <c>physics.serverragdollmode</c>.</summary>
    public static PhysicsServerragdollmodeCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsServerragdollmodeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.serverragdollmode</c> to <paramref name="value"/>.</summary>
    public static PhysicsServerragdollmodeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PhysicsServerragdollmodeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
