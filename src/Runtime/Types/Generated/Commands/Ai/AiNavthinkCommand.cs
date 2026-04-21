using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, AI entities update their NavMesh agent destinations each tick; disable to freeze AI movement while keeping brain logic running</summary>
/// <remarks>Full RCON name: <c>ai.navthink</c></remarks>
public sealed class AiNavthinkCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.navthink";

    /// <summary>Reads the current value of <c>ai.navthink</c>.</summary>
    public static AiNavthinkCommand CreateGet()
    {
        var cmd = CreatePackage<AiNavthinkCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.navthink</c> to <paramref name="value"/>.</summary>
    public static AiNavthinkCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNavthinkCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
