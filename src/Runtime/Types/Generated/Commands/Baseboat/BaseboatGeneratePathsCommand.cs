using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, procedural patrol paths are generated for boats at server startup; false in editor to skip path generation during testing</summary>
/// <remarks>Full RCON name: <c>baseboat.generate_paths</c></remarks>
public sealed class BaseboatGeneratePathsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "baseboat.generate_paths";

    /// <summary>Reads the current value of <c>baseboat.generate_paths</c>.</summary>
    public static BaseboatGeneratePathsCommand CreateGet()
    {
        var cmd = CreatePackage<BaseboatGeneratePathsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>baseboat.generate_paths</c> to <paramref name="value"/>.</summary>
    public static BaseboatGeneratePathsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BaseboatGeneratePathsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
