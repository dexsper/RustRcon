using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>0 Random, 1 North, 2 East, 3 South, 4 West</summary>
/// <remarks>Full RCON name: <c>deepsea.forceentranceportaldirection</c></remarks>
public sealed class DeepseaForceentranceportaldirectionCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.forceentranceportaldirection";

    /// <summary>Reads the current value of <c>deepsea.forceentranceportaldirection</c>.</summary>
    public static DeepseaForceentranceportaldirectionCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaForceentranceportaldirectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.forceentranceportaldirection</c> to <paramref name="value"/>.</summary>
    public static DeepseaForceentranceportaldirectionCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DeepseaForceentranceportaldirectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
