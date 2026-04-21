using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, Unity Physics auto-syncs transform changes to physics each frame; disable to manually control when transforms sync</summary>
/// <remarks>Full RCON name: <c>physics.autosynctransforms</c></remarks>
public sealed class PhysicsAutosynctransformsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.autosynctransforms";

    /// <summary>Reads the current value of <c>physics.autosynctransforms</c>.</summary>
    public static PhysicsAutosynctransformsCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsAutosynctransformsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.autosynctransforms</c> to <paramref name="value"/>.</summary>
    public static PhysicsAutosynctransformsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PhysicsAutosynctransformsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
