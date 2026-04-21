using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>networkprofiler.serverprofile [time to profile(in seconds), min(0.1), max(1000), float]</summary>
/// <remarks>Full RCON name: <c>networkprofiler.serverprofile</c></remarks>
public sealed class NetworkprofilerServerprofileCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "networkprofiler.serverprofile";

    /// <summary>Creates a new <see cref="NetworkprofilerServerprofileCommand"/> command.</summary>
    public static NetworkprofilerServerprofileCommand Create()
    {
        var cmd = CreatePackage<NetworkprofilerServerprofileCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
