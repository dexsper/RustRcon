using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) URL endpoint to which full server demo files are uploaded after recording; leave empty to disable demo uploads</summary>
/// <remarks>Full RCON name: <c>demo.upload_url</c></remarks>
public sealed class DemoUploadUrlCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.upload_url";

    /// <summary>Reads the current value of <c>demo.upload_url</c>.</summary>
    public static DemoUploadUrlCommand CreateGet()
    {
        var cmd = CreatePackage<DemoUploadUrlCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.upload_url</c> to <paramref name="value"/>.</summary>
    public static DemoUploadUrlCommand CreateSet(string value)
    {
        var cmd = CreatePackage<DemoUploadUrlCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
