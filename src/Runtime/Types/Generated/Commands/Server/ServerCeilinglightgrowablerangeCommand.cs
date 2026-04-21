using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Radius in metres within which a ceiling light provides artificial light that counts toward a growable plant's light requirement</summary>
/// <remarks>Full RCON name: <c>server.ceilinglightgrowablerange</c></remarks>
public sealed class ServerCeilinglightgrowablerangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.ceilinglightgrowablerange";

    /// <summary>Reads the current value of <c>server.ceilinglightgrowablerange</c>.</summary>
    public static ServerCeilinglightgrowablerangeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCeilinglightgrowablerangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.ceilinglightgrowablerange</c> to <paramref name="value"/>.</summary>
    public static ServerCeilinglightgrowablerangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerCeilinglightgrowablerangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
