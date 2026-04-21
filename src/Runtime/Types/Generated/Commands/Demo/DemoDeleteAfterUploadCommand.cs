using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should the full server demos be deleted after they are uploaded</summary>
/// <remarks>Full RCON name: <c>demo.delete_after_upload</c></remarks>
public sealed class DemoDeleteAfterUploadCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.delete_after_upload";

    /// <summary>Reads the current value of <c>demo.delete_after_upload</c>.</summary>
    public static DemoDeleteAfterUploadCommand CreateGet()
    {
        var cmd = CreatePackage<DemoDeleteAfterUploadCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.delete_after_upload</c> to <paramref name="value"/>.</summary>
    public static DemoDeleteAfterUploadCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DemoDeleteAfterUploadCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
