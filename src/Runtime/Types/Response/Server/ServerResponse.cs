using Newtonsoft.Json;
using RustRcon.Pooling;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Types.Response.Server;

/// <summary>
///     Represents a single JSON packet received from the Rust RCON server.
/// </summary>
public sealed class ServerResponse : BasePackage
{
    /// <summary>The server-assigned message type (e.g. <c>Generic</c>, <c>Chat</c>).</summary>
    [JsonProperty("Type")]
    public string Type { get; private set; } = string.Empty;

    /// <summary>Stack trace included when the server encountered an error.</summary>
    [JsonProperty("Stacktrace")]
    public string Stacktrace { get; private set; } = string.Empty;

    /// <summary>Creates and initialises a pooled <see cref="ServerResponse"/>.</summary>
    public static ServerResponse Create(string type, string stacktrace, string content, int id)
    {
        var package = RustRconPool.Get<ServerResponse>();
        package.Id = id;
        package.Content = content;
        package.Type = type;
        package.Stacktrace = stacktrace;
        return package;
    }

    protected override void EnterPool()
    {
        base.EnterPool();
        Type = string.Empty;
        Stacktrace = string.Empty;
    }
}
