using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum voice chat packets per second accepted from each client; reducing this limits voice bandwidth usage per player</summary>
/// <remarks>Full RCON name: <c>server.maxpacketspersecond_voice</c></remarks>
public sealed class ServerMaxpacketspersecondVoiceCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxpacketspersecond_voice";

    /// <summary>Reads the current value of <c>server.maxpacketspersecond_voice</c>.</summary>
    public static ServerMaxpacketspersecondVoiceCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondVoiceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxpacketspersecond_voice</c> to <paramref name="value"/>.</summary>
    public static ServerMaxpacketspersecondVoiceCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondVoiceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
