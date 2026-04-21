using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Vertical offset in metres added when checking whether a ceiling light illuminates a plant directly below it</summary>
/// <remarks>Full RCON name: <c>server.ceilinglightheightoffset</c></remarks>
public sealed class ServerCeilinglightheightoffsetCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.ceilinglightheightoffset";

    /// <summary>Reads the current value of <c>server.ceilinglightheightoffset</c>.</summary>
    public static ServerCeilinglightheightoffsetCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCeilinglightheightoffsetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.ceilinglightheightoffset</c> to <paramref name="value"/>.</summary>
    public static ServerCeilinglightheightoffsetCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerCeilinglightheightoffsetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
