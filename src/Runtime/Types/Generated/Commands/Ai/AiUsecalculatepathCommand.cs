using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, NavMesh path calculation uses the full CalculatePath API; disable to use the simpler SetDestination fallback only</summary>
/// <remarks>Full RCON name: <c>ai.usecalculatepath</c></remarks>
public sealed class AiUsecalculatepathCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.usecalculatepath";

    /// <summary>Reads the current value of <c>ai.usecalculatepath</c>.</summary>
    public static AiUsecalculatepathCommand CreateGet()
    {
        var cmd = CreatePackage<AiUsecalculatepathCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.usecalculatepath</c> to <paramref name="value"/>.</summary>
    public static AiUsecalculatepathCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiUsecalculatepathCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
