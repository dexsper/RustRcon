using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The height of the carve volume. (default: 2)</summary>
/// <remarks>Full RCON name: <c>ai.nav_carve_height</c></remarks>
public sealed class AiNavCarveHeightCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.nav_carve_height";

    /// <summary>Reads the current value of <c>ai.nav_carve_height</c>.</summary>
    public static AiNavCarveHeightCommand CreateGet()
    {
        var cmd = CreatePackage<AiNavCarveHeightCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.nav_carve_height</c> to <paramref name="value"/>.</summary>
    public static AiNavCarveHeightCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNavCarveHeightCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
