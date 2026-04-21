using Newtonsoft.Json;
using RustRcon.Pooling;

namespace RustRcon.Types.Commands.Base;

/// <summary>
///     The base for all RCON packages (commands and responses).
///     Manages a monotonically-increasing packet identifier used to correlate
///     server responses with their originating commands.
/// </summary>
public abstract class BasePackage : BasePoolable
{
    private static int _idCounter = 2;

    /// <summary>
    ///     Packet identifier used by the server to correlate responses.
    ///     Serialised as <c>Identifier</c> in the RCON JSON protocol.
    /// </summary>
    [JsonProperty("Identifier")]
    public int Id { get; protected set; }

    /// <summary>
    ///     The raw RCON command or response body.
    ///     Serialised as <c>Message</c> in the RCON JSON protocol.
    /// </summary>
    [JsonProperty("Message")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    ///     The <c>Name</c> field required by the Rust RCON protocol.
    ///     Always <c>"WebRcon"</c>.
    /// </summary>
    [JsonProperty("Name")]
    public string Name => "WebRcon";

    /// <summary>Obtains a pooled package of type <typeparamref name="T"/>.</summary>
    protected static T CreatePackage<T>() where T : BasePackage, new() => RustRconPool.Get<T>();

    protected override void EnterPool()
    {
        base.EnterPool();
        Id = 0;
        Content = string.Empty;
    }

    protected override void LeavePool()
    {
        base.LeavePool();
        Id = Interlocked.Increment(ref _idCounter);
    }
}
