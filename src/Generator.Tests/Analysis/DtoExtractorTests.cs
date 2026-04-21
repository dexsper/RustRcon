using FluentAssertions;
using RustRcon.Generator.Analysis;

namespace RustRcon.Generator.Tests.Analysis;

public sealed class DtoExtractorTests
{
    private static readonly DtoExtractor Extractor = new();

    private const string AdminSource = @"
namespace ConVar;
public class Admin
{
    public struct PlayerInfo
    {
        public string SteamID { get; set; }
        public string DisplayName { get; set; }
        public int Ping { get; set; }
        public string Address { get; set; }
        public float Health { get; set; }
    }

    public struct ServerInfoOutput
    {
        public string Hostname { get; set; }
        public int MaxPlayers { get; set; }
        public int Players { get; set; }
        public string Map { get; set; }
        public bool Restarting { get; set; }
    }
}";

    private static readonly IReadOnlyDictionary<string, string> Decompiled =
        new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["Admin"] = AdminSource
        };

    [Fact]
    public void Extract_PrimitiveType_ReturnsNull()
    {
        Extractor.Extract("int", Decompiled).Should().BeNull();
        Extractor.Extract("string", Decompiled).Should().BeNull();
        Extractor.Extract("bool", Decompiled).Should().BeNull();
    }

    [Fact]
    public void Extract_EmptyTypeName_ReturnsNull()
    {
        Extractor.Extract(string.Empty, Decompiled).Should().BeNull();
        Extractor.Extract(null, Decompiled).Should().BeNull();
    }

    [Fact]
    public void Extract_UnknownType_ReturnsNull()
    {
        Extractor.Extract("NonExistentType", Decompiled).Should().BeNull();
    }

    [Fact]
    public void Extract_PlayerInfo_ReturnsCorrectDto()
    {
        var dto = Extractor.Extract("PlayerInfo", Decompiled);
        dto.Should().NotBeNull();
        dto!.Name.Should().Be("PlayerInfo");
        dto.Fields.Should().HaveCount(5);
        dto.Fields.Select(f => f.Name).Should().Contain("SteamID", "DisplayName", "Ping", "Address", "Health");
    }

    [Fact]
    public void Extract_ArrayType_ExtractsBaseType()
    {
        var dto = Extractor.Extract("PlayerInfo[]", Decompiled);
        dto.Should().NotBeNull();
        dto!.Name.Should().Be("PlayerInfo");
    }

    [Fact]
    public void Extract_ServerInfoOutput_ExtractsFields()
    {
        var dto = Extractor.Extract("ServerInfoOutput", Decompiled);
        dto.Should().NotBeNull();
        dto!.Fields.Should().HaveCount(5);
        dto.Fields.Select(f => f.TypeName).Should().Contain("bool");
    }

    [Fact]
    public void Extract_QualifiedName_StripsPrefixAndFindsType()
    {
        var dto = Extractor.Extract("Admin.PlayerInfo", Decompiled);
        dto.Should().NotBeNull();
        dto!.Name.Should().Be("PlayerInfo");
    }
}
