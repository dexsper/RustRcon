using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>profile.command_lagspike_threshold</c>.</summary>
/// <remarks>Full RCON name: <c>profile.command_lagspike_threshold</c></remarks>
public sealed class ProfileCommandLagspikeThresholdCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.command_lagspike_threshold";

    /// <summary>Reads the current value of <c>profile.command_lagspike_threshold</c>.</summary>
    public static ProfileCommandLagspikeThresholdCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileCommandLagspikeThresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.command_lagspike_threshold</c> to <paramref name="value"/>.</summary>
    public static ProfileCommandLagspikeThresholdCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileCommandLagspikeThresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
