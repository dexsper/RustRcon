using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, buoyancy point physics updates are batched together each fixed update for better CPU efficiency</summary>
/// <remarks>Full RCON name: <c>buoyancy.use_batching</c></remarks>
public sealed class BuoyancyUseBatchingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "buoyancy.use_batching";

    /// <summary>Reads the current value of <c>buoyancy.use_batching</c>.</summary>
    public static BuoyancyUseBatchingCommand CreateGet()
    {
        var cmd = CreatePackage<BuoyancyUseBatchingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>buoyancy.use_batching</c> to <paramref name="value"/>.</summary>
    public static BuoyancyUseBatchingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BuoyancyUseBatchingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
