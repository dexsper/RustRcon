using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Flushes any buffered analytics events immediately to the analytics backend rather than waiting for the next scheduled flush</summary>
/// <remarks>Full RCON name: <c>profile.flush_analytics</c></remarks>
public sealed class ProfileFlushAnalyticsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.flush_analytics";

    /// <summary>Creates a new <see cref="ProfileFlushAnalyticsCommand"/> command.</summary>
    public static ProfileFlushAnalyticsCommand Create()
    {
        var cmd = CreatePackage<ProfileFlushAnalyticsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
