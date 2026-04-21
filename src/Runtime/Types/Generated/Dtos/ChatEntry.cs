using Newtonsoft.Json;

namespace RustRcon.Generated.Dtos;

/// <summary>Generated DTO — do not edit by hand.</summary>
public sealed class ChatEntry
{
    [JsonProperty("Channel")]
    public ChatChannel Channel { get; set; }

    [JsonProperty("Message")]
    public string Message { get; set; } = string.Empty;

    [JsonProperty("UserId")]
    public string UserId { get; set; } = string.Empty;

    [JsonProperty("Username")]
    public string Username { get; set; } = string.Empty;

    [JsonProperty("Color")]
    public string Color { get; set; } = string.Empty;

    [JsonProperty("Time")]
    public int Time { get; set; }

}
