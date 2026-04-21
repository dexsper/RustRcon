using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Build blocks for free</summary>
/// <remarks>Full RCON name: <c>creative.freebuild</c></remarks>
public sealed class CreativeFreebuildCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "creative.freebuild";

    /// <summary>Reads the current value of <c>creative.freebuild</c>.</summary>
    public static CreativeFreebuildCommand CreateGet()
    {
        var cmd = CreatePackage<CreativeFreebuildCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>creative.freebuild</c> to <paramref name="value"/>.</summary>
    public static CreativeFreebuildCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CreativeFreebuildCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
