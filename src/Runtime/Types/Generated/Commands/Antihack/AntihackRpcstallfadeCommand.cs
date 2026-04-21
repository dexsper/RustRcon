using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.rpcstallfade</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.rpcstallfade</c></remarks>
public sealed class AntihackRpcstallfadeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.rpcstallfade";

    /// <summary>Reads the current value of <c>antihack.rpcstallfade</c>.</summary>
    public static AntihackRpcstallfadeCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackRpcstallfadeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.rpcstallfade</c> to <paramref name="value"/>.</summary>
    public static AntihackRpcstallfadeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackRpcstallfadeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
