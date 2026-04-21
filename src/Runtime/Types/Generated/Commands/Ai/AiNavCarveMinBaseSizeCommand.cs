using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The minimum size we allow a carving volume to be. (default: 2)</summary>
/// <remarks>Full RCON name: <c>ai.nav_carve_min_base_size</c></remarks>
public sealed class AiNavCarveMinBaseSizeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.nav_carve_min_base_size";

    /// <summary>Reads the current value of <c>ai.nav_carve_min_base_size</c>.</summary>
    public static AiNavCarveMinBaseSizeCommand CreateGet()
    {
        var cmd = CreatePackage<AiNavCarveMinBaseSizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.nav_carve_min_base_size</c> to <paramref name="value"/>.</summary>
    public static AiNavCarveMinBaseSizeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNavCarveMinBaseSizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
