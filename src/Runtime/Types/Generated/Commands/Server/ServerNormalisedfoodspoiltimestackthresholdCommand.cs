using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If two spoiled food items are both above this threshold then we will allow them to be stacked</summary>
/// <remarks>Full RCON name: <c>server.normalisedfoodspoiltimestackthreshold</c></remarks>
public sealed class ServerNormalisedfoodspoiltimestackthresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.normalisedfoodspoiltimestackthreshold";

    /// <summary>Reads the current value of <c>server.normalisedfoodspoiltimestackthreshold</c>.</summary>
    public static ServerNormalisedfoodspoiltimestackthresholdCommand CreateGet()
    {
        var cmd = CreatePackage<ServerNormalisedfoodspoiltimestackthresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.normalisedfoodspoiltimestackthreshold</c> to <paramref name="value"/>.</summary>
    public static ServerNormalisedfoodspoiltimestackthresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerNormalisedfoodspoiltimestackthresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
