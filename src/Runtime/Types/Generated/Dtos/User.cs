using Newtonsoft.Json;

namespace RustRcon.Generated.Dtos;

/// <summary>Generated DTO — do not edit by hand.</summary>
public sealed class User
{
    [JsonProperty("IsExpired")]
    public bool IsExpired { get; set; }

    [JsonProperty("Steamid")]
    public ulong Steamid { get; set; }

    [JsonProperty("Group")]
    public UserGroup Group { get; set; }

    [JsonProperty("Username")]
    public string Username { get; set; } = string.Empty;

    [JsonProperty("Notes")]
    public string Notes { get; set; } = string.Empty;

    [JsonProperty("Expiry")]
    public long Expiry { get; set; }

}
