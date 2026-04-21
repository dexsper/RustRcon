using Newtonsoft.Json;

namespace RustRcon.Generated.Dtos;

/// <summary>Generated DTO — do not edit by hand.</summary>
public sealed class ServerInfoOutput
{
    [JsonProperty("Hostname")]
    public string Hostname { get; set; } = string.Empty;

    [JsonProperty("MaxPlayers")]
    public int MaxPlayers { get; set; }

    [JsonProperty("Players")]
    public int Players { get; set; }

    [JsonProperty("Queued")]
    public int Queued { get; set; }

    [JsonProperty("Joining")]
    public int Joining { get; set; }

    [JsonProperty("ReservedSlots")]
    public int ReservedSlots { get; set; }

    [JsonProperty("EntityCount")]
    public int EntityCount { get; set; }

    [JsonProperty("GameTime")]
    public string GameTime { get; set; } = string.Empty;

    [JsonProperty("Uptime")]
    public int Uptime { get; set; }

    [JsonProperty("Map")]
    public string Map { get; set; } = string.Empty;

    [JsonProperty("Framerate")]
    public float Framerate { get; set; }

    [JsonProperty("Memory")]
    public int Memory { get; set; }

    [JsonProperty("MemoryUsageSystem")]
    public int MemoryUsageSystem { get; set; }

    [JsonProperty("Collections")]
    public int Collections { get; set; }

    [JsonProperty("NetworkIn")]
    public int NetworkIn { get; set; }

    [JsonProperty("NetworkOut")]
    public int NetworkOut { get; set; }

    [JsonProperty("Restarting")]
    public bool Restarting { get; set; }

    [JsonProperty("SaveCreatedTime")]
    public string SaveCreatedTime { get; set; } = string.Empty;

    [JsonProperty("Version")]
    public int Version { get; set; }

    [JsonProperty("Protocol")]
    public string Protocol { get; set; } = string.Empty;

}
