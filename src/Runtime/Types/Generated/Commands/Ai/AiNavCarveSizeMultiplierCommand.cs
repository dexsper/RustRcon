using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The size multiplier applied to the size of the carve volume. The smaller the value, the tighter the skirt around foundation edges, but too small and animals can attack through walls. (default: 4)</summary>
/// <remarks>Full RCON name: <c>ai.nav_carve_size_multiplier</c></remarks>
public sealed class AiNavCarveSizeMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.nav_carve_size_multiplier";

    /// <summary>Reads the current value of <c>ai.nav_carve_size_multiplier</c>.</summary>
    public static AiNavCarveSizeMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<AiNavCarveSizeMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.nav_carve_size_multiplier</c> to <paramref name="value"/>.</summary>
    public static AiNavCarveSizeMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNavCarveSizeMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
