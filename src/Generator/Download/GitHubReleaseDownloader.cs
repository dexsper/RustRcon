using System.IO.Compression;
using Newtonsoft.Json;

namespace RustRcon.Generator.Download;

/// <summary>
///     Downloads the latest Oxide.Rust release from GitHub, extracts the
///     entire managed DLL folder, and caches it locally so subsequent
///     runs skip the download when the version hasn't changed.
/// </summary>
public sealed class GitHubReleaseDownloader
{
    private const string ReleasesApiUrl =
        "https://api.github.com/repos/OxideMod/Oxide.Rust/releases/latest";

    private const string PreferredAssetName = "Oxide.Rust.zip";
    private const string PrimaryDll         = "Assembly-CSharp.dll";
    private const string VersionFile        = "version.json";

    private readonly string _cacheDir;
    private readonly HttpClient _httpClient;

    /// <param name="cacheDir">Directory used to store the cached DLLs and version metadata.</param>
    /// <param name="httpClient">Optional pre-configured <see cref="HttpClient"/>.</param>
    public GitHubReleaseDownloader(string cacheDir, HttpClient? httpClient = null)
    {
        _cacheDir = cacheDir;
        Directory.CreateDirectory(cacheDir);
        _httpClient = httpClient ?? CreateDefaultClient();
    }

    /// <summary>Directory containing all extracted managed DLLs.</summary>
    public string ManagedDir => Path.Combine(_cacheDir, "managed");

    /// <summary>Path to the primary <c>Assembly-CSharp.dll</c>.</summary>
    public string CachedDllPath => Path.Combine(ManagedDir, PrimaryDll);

    /// <summary>
    ///     Ensures the local cache contains the latest version of all managed DLLs.
    ///     Downloads and extracts only when the remote tag differs from the cached one.
    /// </summary>
    /// <returns>The Oxide.Rust release tag that was resolved, e.g. <c>2.0.7286</c>.</returns>
    public async Task<string> EnsureLatestAsync(
        bool forceRefresh = false,
        IProgress<string>? progress = null,
        CancellationToken cancellation = default)
    {
        progress?.Report("Fetching latest Oxide.Rust release info…");
        var release = await FetchLatestReleaseAsync(cancellation);

        var cachedTag = ReadCachedTag();

        if (!forceRefresh && cachedTag == release.TagName && File.Exists(CachedDllPath))
        {
            progress?.Report($"Cache is up-to-date (tag {release.TagName}). Skipping download.");
            return release.TagName;
        }

        var asset = release.Assets.FirstOrDefault(a =>
                        string.Equals(a.Name, PreferredAssetName, StringComparison.OrdinalIgnoreCase))
                    ?? release.Assets.FirstOrDefault(a =>
                        a.Name.EndsWith(".zip", StringComparison.OrdinalIgnoreCase));

        if (asset is null)
            throw new InvalidOperationException(
                $"No zip asset found in Oxide.Rust release {release.TagName}.");

        progress?.Report($"Downloading {asset.Name} (tag {release.TagName})…");
        var count = await DownloadAndExtractAsync(asset.DownloadUrl, cancellation);
        progress?.Report($"Extracted {count} DLL(s) to managed dir.");

        WriteCachedTag(release.TagName);
        progress?.Report($"Download complete. Cached tag: {release.TagName}");
        return release.TagName;
    }

    private async Task<OxideReleaseInfo> FetchLatestReleaseAsync(CancellationToken cancellation)
    {
        var json = await _httpClient.GetStringAsync(ReleasesApiUrl, cancellation);
        return JsonConvert.DeserializeObject<OxideReleaseInfo>(json)
               ?? throw new InvalidOperationException("GitHub API returned empty release info.");
    }

    /// <summary>Extracts every <c>*.dll</c> from the zip into <see cref="ManagedDir"/>.</summary>
    private async Task<int> DownloadAndExtractAsync(string downloadUrl, CancellationToken cancellation)
    {
        Directory.CreateDirectory(ManagedDir);

        await using var zipStream = await _httpClient.GetStreamAsync(downloadUrl, cancellation);
        using var archive = new ZipArchive(zipStream, ZipArchiveMode.Read, leaveOpen: false);

        int count = 0;
        foreach (var entry in archive.Entries)
        {
            if (!entry.FullName.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
                continue;

            var dest = Path.Combine(ManagedDir, Path.GetFileName(entry.FullName));
            await using var entryStream = entry.Open();
            await using var fileStream  = File.Create(dest);
            await entryStream.CopyToAsync(fileStream, cancellation);
            count++;
        }

        if (count == 0)
            throw new InvalidOperationException("No DLL files found inside the downloaded zip.");

        return count;
    }

    private string ReadCachedTag()
    {
        var path = Path.Combine(_cacheDir, VersionFile);
        if (!File.Exists(path)) return string.Empty;
        try
        {
            var info = JsonConvert.DeserializeObject<CachedVersionInfo>(File.ReadAllText(path));
            return info?.Tag ?? string.Empty;
        }
        catch { return string.Empty; }
    }

    private void WriteCachedTag(string tag)
    {
        var path = Path.Combine(_cacheDir, VersionFile);
        File.WriteAllText(path, JsonConvert.SerializeObject(new CachedVersionInfo { Tag = tag }));
    }

    private static HttpClient CreateDefaultClient()
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.UserAgent.ParseAdd("RustRcon.Generator/2.0");
        return client;
    }
}
