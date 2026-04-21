using RustRcon.Pooling;

namespace RustRcon.Types.Server.Messages;

/// <summary>A chat message received from the server over RCON.</summary>
public sealed class ChatMsg : BasePoolable
{
    /// <summary>Channel identifier (0 = global, 1 = team, 2 = local).</summary>
    public int Channel { get; set; }

    /// <summary>Message text.</summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>Steam64 ID of the sender.</summary>
    public long UserId { get; set; }

    /// <summary>Display name of the sender.</summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>Hex colour of the sender's name (e.g. <c>#5af</c>).</summary>
    public string Color { get; set; } = string.Empty;

    /// <summary>Unix timestamp of the message.</summary>
    public long Time { get; set; }

    protected override void EnterPool()
    {
        Channel = 0;
        Message = string.Empty;
        UserId = 0;
        Username = string.Empty;
        Color = string.Empty;
        Time = 0;
    }
}
