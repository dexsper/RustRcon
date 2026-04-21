using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Retry initializing the Rust+ companion server if it previously failed</summary>
/// <remarks>Full RCON name: <c>app.retry_initialize</c></remarks>
public sealed class AppRetryInitializeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.retry_initialize";

    /// <summary>Creates a new <see cref="AppRetryInitializeCommand"/> command.</summary>
    public static AppRetryInitializeCommand Create()
    {
        var cmd = CreatePackage<AppRetryInitializeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
