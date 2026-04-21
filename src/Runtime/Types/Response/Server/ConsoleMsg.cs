using RustRcon.Pooling;

namespace RustRcon.Types.Server.Messages;

/// <summary>A server console message received over RCON.</summary>
public sealed class ConsoleMsg : BasePoolable
{
    /// <summary>Message severity / category.</summary>
    public enum MessageType
    {
        Generic,
        Log,
        Error,
        Warning
    }

    /// <summary>The console message text.</summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>The message severity.</summary>
    public MessageType Type { get; set; }

    protected override void EnterPool()
    {
        base.EnterPool();
        Message = string.Empty;
        Type = MessageType.Generic;
    }
}
