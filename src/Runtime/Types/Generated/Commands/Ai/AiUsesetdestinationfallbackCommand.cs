using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, falls back to SetDestination if CalculatePath fails to find a valid path to the target</summary>
/// <remarks>Full RCON name: <c>ai.usesetdestinationfallback</c></remarks>
public sealed class AiUsesetdestinationfallbackCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.usesetdestinationfallback";

    /// <summary>Reads the current value of <c>ai.usesetdestinationfallback</c>.</summary>
    public static AiUsesetdestinationfallbackCommand CreateGet()
    {
        var cmd = CreatePackage<AiUsesetdestinationfallbackCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.usesetdestinationfallback</c> to <paramref name="value"/>.</summary>
    public static AiUsesetdestinationfallbackCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiUsesetdestinationfallbackCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
