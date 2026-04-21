using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum time in seconds that surrounding-support check jobs can run per server tick before deferral</summary>
/// <remarks>Full RCON name: <c>stability.surroundingsqueue</c></remarks>
public sealed class StabilitySurroundingsqueueCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stability.surroundingsqueue";

    /// <summary>Reads the current value of <c>stability.surroundingsqueue</c>.</summary>
    public static StabilitySurroundingsqueueCommand CreateGet()
    {
        var cmd = CreatePackage<StabilitySurroundingsqueueCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>stability.surroundingsqueue</c> to <paramref name="value"/>.</summary>
    public static StabilitySurroundingsqueueCommand CreateSet(float value)
    {
        var cmd = CreatePackage<StabilitySurroundingsqueueCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
