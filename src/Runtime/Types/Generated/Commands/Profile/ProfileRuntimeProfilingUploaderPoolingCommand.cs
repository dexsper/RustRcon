using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should analytics bulk uploaders use pooling</summary>
/// <remarks>Full RCON name: <c>profile.runtime_profiling_uploader_pooling</c></remarks>
public sealed class ProfileRuntimeProfilingUploaderPoolingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.runtime_profiling_uploader_pooling";

    /// <summary>Reads the current value of <c>profile.runtime_profiling_uploader_pooling</c>.</summary>
    public static ProfileRuntimeProfilingUploaderPoolingCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingUploaderPoolingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.runtime_profiling_uploader_pooling</c> to <paramref name="value"/>.</summary>
    public static ProfileRuntimeProfilingUploaderPoolingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingUploaderPoolingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
