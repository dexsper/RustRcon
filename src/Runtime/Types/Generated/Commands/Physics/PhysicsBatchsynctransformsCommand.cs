using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, physics transform syncs are batched per frame for efficiency; disable to force immediate per-object sync</summary>
/// <remarks>Full RCON name: <c>physics.batchsynctransforms</c></remarks>
public sealed class PhysicsBatchsynctransformsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.batchsynctransforms";

    /// <summary>Reads the current value of <c>physics.batchsynctransforms</c>.</summary>
    public static PhysicsBatchsynctransformsCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsBatchsynctransformsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.batchsynctransforms</c> to <paramref name="value"/>.</summary>
    public static PhysicsBatchsynctransformsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PhysicsBatchsynctransformsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
