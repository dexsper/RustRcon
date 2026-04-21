using Newtonsoft.Json;

namespace RustRcon.Generator.Download;

/// <summary>Minimal shape of the GitHub releases API response.</summary>
internal sealed class OxideReleaseInfo
{
    [JsonProperty("tag_name")]
    public string TagName { get; set; } = string.Empty;

    [JsonProperty("assets")]
    public List<OxideReleaseAsset> Assets { get; set; } = new();
}

internal sealed class OxideReleaseAsset
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("browser_download_url")]
    public string DownloadUrl { get; set; } = string.Empty;
}

/// <summary>Persisted cache metadata.</summary>
internal sealed class CachedVersionInfo
{
    [JsonProperty("tag")]
    public string Tag { get; set; } = string.Empty;
}
