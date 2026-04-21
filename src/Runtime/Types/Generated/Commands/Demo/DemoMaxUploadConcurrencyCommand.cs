using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Max parallel requests when uploading demos</summary>
/// <remarks>Full RCON name: <c>demo.max_upload_concurrency</c></remarks>
public sealed class DemoMaxUploadConcurrencyCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.max_upload_concurrency";

    /// <summary>Reads the current value of <c>demo.max_upload_concurrency</c>.</summary>
    public static DemoMaxUploadConcurrencyCommand CreateGet()
    {
        var cmd = CreatePackage<DemoMaxUploadConcurrencyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.max_upload_concurrency</c> to <paramref name="value"/>.</summary>
    public static DemoMaxUploadConcurrencyCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DemoMaxUploadConcurrencyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
