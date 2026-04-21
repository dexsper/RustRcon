using Newtonsoft.Json;

namespace RustRcon.Generated.Dtos;

/// <summary>Generated DTO — do not edit by hand.</summary>
public sealed class PlayerIDInfo
{
    [JsonProperty("SteamID")]
    public string SteamID { get; set; } = string.Empty;

    [JsonProperty("OwnerSteamID")]
    public string OwnerSteamID { get; set; } = string.Empty;

    [JsonProperty("DisplayName")]
    public string DisplayName { get; set; } = string.Empty;

    [JsonProperty("Address")]
    public string Address { get; set; } = string.Empty;

    [JsonProperty("EntityId")]
    public ulong EntityId { get; set; }

}
