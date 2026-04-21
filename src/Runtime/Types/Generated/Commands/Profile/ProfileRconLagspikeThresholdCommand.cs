using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>profile.rcon_lagspike_threshold</c>.</summary>
/// <remarks>Full RCON name: <c>profile.rcon_lagspike_threshold</c></remarks>
public sealed class ProfileRconLagspikeThresholdCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.rcon_lagspike_threshold";

    /// <summary>Reads the current value of <c>profile.rcon_lagspike_threshold</c>.</summary>
    public static ProfileRconLagspikeThresholdCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileRconLagspikeThresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.rcon_lagspike_threshold</c> to <paramref name="value"/>.</summary>
    public static ProfileRconLagspikeThresholdCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileRconLagspikeThresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
