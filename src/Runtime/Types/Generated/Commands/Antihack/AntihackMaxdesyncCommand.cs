using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.maxdesync</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.maxdesync</c></remarks>
public sealed class AntihackMaxdesyncCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.maxdesync";

    /// <summary>Reads the current value of <c>antihack.maxdesync</c>.</summary>
    public static AntihackMaxdesyncCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMaxdesyncCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.maxdesync</c> to <paramref name="value"/>.</summary>
    public static AntihackMaxdesyncCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackMaxdesyncCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
