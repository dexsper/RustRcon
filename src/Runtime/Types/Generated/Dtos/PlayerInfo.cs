using Newtonsoft.Json;

namespace RustRcon.Generated.Dtos;

/// <summary>Generated DTO — do not edit by hand.</summary>
public sealed class PlayerInfo
{
    [JsonProperty("SteamID")]
    public string SteamID { get; set; } = string.Empty;

    [JsonProperty("OwnerSteamID")]
    public string OwnerSteamID { get; set; } = string.Empty;

    [JsonProperty("DisplayName")]
    public string DisplayName { get; set; } = string.Empty;

    [JsonProperty("Ping")]
    public int Ping { get; set; }

    [JsonProperty("Address")]
    public string Address { get; set; } = string.Empty;

    [JsonProperty("EntityId")]
    public ulong EntityId { get; set; }

    [JsonProperty("ConnectedSeconds")]
    public int ConnectedSeconds { get; set; }

    [JsonProperty("ViolationLevel")]
    public float ViolationLevel { get; set; }

    [JsonProperty("CurrentLevel")]
    public float CurrentLevel { get; set; }

    [JsonProperty("Health")]
    public float Health { get; set; }

    [JsonProperty("Position")]
    public Vector3 Position { get; set; }

    [JsonProperty("IsMuted")]
    public bool IsMuted { get; set; }

    [JsonProperty("TeamID")]
    public ulong TeamID { get; set; }

}
