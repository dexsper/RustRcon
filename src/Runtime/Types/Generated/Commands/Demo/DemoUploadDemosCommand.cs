using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, completed server demo files are automatically uploaded to the configured UploadUrl endpoint after recording finishes</summary>
/// <remarks>Full RCON name: <c>demo.upload_demos</c></remarks>
public sealed class DemoUploadDemosCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.upload_demos";

    /// <summary>Reads the current value of <c>demo.upload_demos</c>.</summary>
    public static DemoUploadDemosCommand CreateGet()
    {
        var cmd = CreatePackage<DemoUploadDemosCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.upload_demos</c> to <paramref name="value"/>.</summary>
    public static DemoUploadDemosCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DemoUploadDemosCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
