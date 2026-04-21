using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much water a player needs to be in to be ignored</summary>
/// <remarks>Full RCON name: <c>beeswarmai.waterthreshold</c></remarks>
public sealed class BeeswarmaiWaterthresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beeswarmai.waterthreshold";

    /// <summary>Reads the current value of <c>beeswarmai.waterthreshold</c>.</summary>
    public static BeeswarmaiWaterthresholdCommand CreateGet()
    {
        var cmd = CreatePackage<BeeswarmaiWaterthresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beeswarmai.waterthreshold</c> to <paramref name="value"/>.</summary>
    public static BeeswarmaiWaterthresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BeeswarmaiWaterthresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
