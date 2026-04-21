using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Controls whether perfsnapshot commands emit chat messages</summary>
/// <remarks>Full RCON name: <c>profile.quiet</c></remarks>
public sealed class ProfileQuietCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.quiet";

    /// <summary>Reads the current value of <c>profile.quiet</c>.</summary>
    public static ProfileQuietCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileQuietCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.quiet</c> to <paramref name="value"/>.</summary>
    public static ProfileQuietCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ProfileQuietCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
