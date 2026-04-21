using System.IO.Compression;
using System.Net;
using System.Text;
using FluentAssertions;
using Moq;
using Moq.Protected;
using RustRcon.Generator.Download;

namespace RustRcon.Generator.Tests.Download;

public sealed class GitHubReleaseDownloaderTests : IDisposable
{
    private readonly string _tempDir =
        Path.Combine(Path.GetTempPath(), $"RustRconTest_{Guid.NewGuid():N}");

    public void Dispose()
    {
        if (Directory.Exists(_tempDir))
            Directory.Delete(_tempDir, recursive: true);
    }

    private static HttpClient CreateMockClient(string latestApiJson, byte[]? zipBytes = null)
    {
        var handler = new Mock<HttpMessageHandler>();

        handler.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(r => r.RequestUri!.ToString().Contains("releases/latest")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(latestApiJson, Encoding.UTF8, "application/json")
            });

        if (zipBytes is not null)
        {
            handler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(r => r.RequestUri!.ToString().Contains("download")),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent(zipBytes)
                });
        }

        return new HttpClient(handler.Object);
    }

    /// <summary>Builds a zip archive containing a fake Assembly-CSharp.dll.</summary>
    private static byte[] BuildZipWithDll(string content = "FAKE_DLL_CONTENT")
    {
        using var ms = new MemoryStream();
        using (var archive = new ZipArchive(ms, ZipArchiveMode.Create, leaveOpen: true))
        {
            var entry = archive.CreateEntry("Managed/Assembly-CSharp.dll");
            using var entryStream = entry.Open();
            entryStream.Write(Encoding.UTF8.GetBytes(content));
        }
        return ms.ToArray();
    }

    /// <summary>Pre-creates the managed dir with a cached DLL at the correct path.</summary>
    private async Task<string> PrePopulateCache(string tag, string dllContent = "CACHED_DLL")
    {
        var managedDir = Path.Combine(_tempDir, "managed");
        Directory.CreateDirectory(managedDir);
        await File.WriteAllTextAsync(
            Path.Combine(_tempDir, "version.json"),
            $"{{\"tag\":\"{tag}\"}}");
        var dllPath = Path.Combine(managedDir, "Assembly-CSharp.dll");
        await File.WriteAllTextAsync(dllPath, dllContent);
        return dllPath;
    }

    private const string LatestReleaseJson = """
        {
            "tag_name": "2.0.9999",
            "assets": [
                {
                    "name": "Oxide.Rust.zip",
                    "browser_download_url": "https://example.com/download/Oxide.Rust.zip"
                }
            ]
        }
        """;

    [Fact]
    public async Task EnsureLatestAsync_NewVersion_DownloadsAndExtractsDll()
    {
        var zip    = BuildZipWithDll();
        var client = CreateMockClient(LatestReleaseJson, zip);
        var sut    = new GitHubReleaseDownloader(_tempDir, client);

        var tag = await sut.EnsureLatestAsync();

        tag.Should().Be("2.0.9999");
        File.Exists(sut.CachedDllPath).Should().BeTrue(
            "Assembly-CSharp.dll must be extracted into the managed subdirectory");
        File.Exists(Path.Combine(_tempDir, "version.json")).Should().BeTrue();
    }

    [Fact]
    public async Task EnsureLatestAsync_SameVersion_SkipsDownload()
    {
        // Pre-populate cache with current tag.
        await PrePopulateCache("2.0.9999", "CACHED_DLL");

        var downloadCount = 0;
        var handler = new Mock<HttpMessageHandler>();
        handler.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(r => r.RequestUri!.ToString().Contains("releases/latest")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(LatestReleaseJson, Encoding.UTF8, "application/json")
            });
        handler.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(r => r.RequestUri!.ToString().Contains("download")),
                ItExpr.IsAny<CancellationToken>())
            .Callback(() => downloadCount++)
            .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(BuildZipWithDll())
            });

        var sut = new GitHubReleaseDownloader(_tempDir, new HttpClient(handler.Object));
        var tag = await sut.EnsureLatestAsync(forceRefresh: false);

        tag.Should().Be("2.0.9999");
        downloadCount.Should().Be(0, "no download should occur when version is already current");
        File.ReadAllText(sut.CachedDllPath).Should().Be("CACHED_DLL");
    }

    [Fact]
    public async Task EnsureLatestAsync_ForceRefresh_AlwaysDownloads()
    {
        await PrePopulateCache("2.0.9999", "OLD_CONTENT");

        var zip    = BuildZipWithDll("NEW_DLL_CONTENT");
        var client = CreateMockClient(LatestReleaseJson, zip);
        var sut    = new GitHubReleaseDownloader(_tempDir, client);

        await sut.EnsureLatestAsync(forceRefresh: true);

        File.ReadAllText(sut.CachedDllPath).Should().Be("NEW_DLL_CONTENT");
    }

    [Fact]
    public async Task EnsureLatestAsync_ExtractsAllDllsFromZip()
    {
        // Build zip with multiple DLLs.
        using var ms = new MemoryStream();
        using (var archive = new ZipArchive(ms, ZipArchiveMode.Create, leaveOpen: true))
        {
            foreach (var name in new[] { "Assembly-CSharp.dll", "Facepunch.System.dll" })
            {
                var entry = archive.CreateEntry($"Managed/{name}");
                using var s = entry.Open();
                s.Write(Encoding.UTF8.GetBytes($"CONTENT_{name}"));
            }
        }

        var client = CreateMockClient(LatestReleaseJson, ms.ToArray());
        var sut    = new GitHubReleaseDownloader(_tempDir, client);
        await sut.EnsureLatestAsync();

        var managedDir = sut.ManagedDir;
        File.Exists(Path.Combine(managedDir, "Assembly-CSharp.dll")).Should().BeTrue();
        File.Exists(Path.Combine(managedDir, "Facepunch.System.dll")).Should().BeTrue();
    }

    [Fact]
    public async Task EnsureLatestAsync_MalformedJson_ThrowsException()
    {
        var client = CreateMockClient("{ invalid json }");
        var sut    = new GitHubReleaseDownloader(_tempDir, client);

        await Assert.ThrowsAnyAsync<Exception>(() => sut.EnsureLatestAsync());
    }

    [Fact]
    public void ManagedDir_IsSubdirectoryOfCacheDir()
    {
        var sut = new GitHubReleaseDownloader(_tempDir);
        sut.ManagedDir.Should().StartWith(_tempDir);
        Path.GetFileName(sut.ManagedDir).Should().Be("managed");
    }

    [Fact]
    public void CachedDllPath_PointsInsideManagedDir()
    {
        var sut = new GitHubReleaseDownloader(_tempDir);
        sut.CachedDllPath.Should().StartWith(sut.ManagedDir);
        Path.GetFileName(sut.CachedDllPath).Should().Be("Assembly-CSharp.dll");
    }
}
