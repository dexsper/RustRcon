using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>A list of radio stations that are valid on this server. Format: NAME,URL,NAME,URL,etc</summary>
/// <remarks>Full RCON name: <c>boombox.serverurllist</c></remarks>
public sealed class BoomboxServerurllistCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boombox.serverurllist";

    /// <summary>Reads the current value of <c>boombox.serverurllist</c>.</summary>
    public static BoomboxServerurllistCommand CreateGet()
    {
        var cmd = CreatePackage<BoomboxServerurllistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boombox.serverurllist</c> to <paramref name="value"/>.</summary>
    public static BoomboxServerurllistCommand CreateSet(string value)
    {
        var cmd = CreatePackage<BoomboxServerurllistCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
