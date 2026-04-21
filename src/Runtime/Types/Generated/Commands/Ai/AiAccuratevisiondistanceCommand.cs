using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, vision distance checks use per-bone raycasts for accuracy; disable to use a single origin ray for performance</summary>
/// <remarks>Full RCON name: <c>ai.accuratevisiondistance</c></remarks>
public sealed class AiAccuratevisiondistanceCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.accuratevisiondistance";

    /// <summary>Reads the current value of <c>ai.accuratevisiondistance</c>.</summary>
    public static AiAccuratevisiondistanceCommand CreateGet()
    {
        var cmd = CreatePackage<AiAccuratevisiondistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.accuratevisiondistance</c> to <paramref name="value"/>.</summary>
    public static AiAccuratevisiondistanceCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiAccuratevisiondistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
