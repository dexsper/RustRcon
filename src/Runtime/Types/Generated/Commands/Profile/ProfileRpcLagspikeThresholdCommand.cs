using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>profile.rpc_lagspike_threshold</c>.</summary>
/// <remarks>Full RCON name: <c>profile.rpc_lagspike_threshold</c></remarks>
public sealed class ProfileRpcLagspikeThresholdCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.rpc_lagspike_threshold";

    /// <summary>Reads the current value of <c>profile.rpc_lagspike_threshold</c>.</summary>
    public static ProfileRpcLagspikeThresholdCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileRpcLagspikeThresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.rpc_lagspike_threshold</c> to <paramref name="value"/>.</summary>
    public static ProfileRpcLagspikeThresholdCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileRpcLagspikeThresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
