using FluentAssertions;
using RustRcon.Generator.Analysis;

namespace RustRcon.Generator.Tests.Analysis;

public sealed class EnumExtractorTests
{
    private readonly EnumExtractor _sut = new();

    private static IReadOnlyDictionary<string, string> Src(string key, string source) =>
        new Dictionary<string, string>(StringComparer.Ordinal) { [key] = source };

    [Fact]
    public void Extract_EnumWithExplicitValues_ReturnsCorrectMembers()
    {
        const string source = """
            public class ServerUsers
            {
                public enum UserGroup
                {
                    None = 0,
                    Banned = 1,
                    Moderator = 2,
                    Owner = 3,
                }
            }
            """;

        var result = _sut.Extract("UserGroup", Src("ServerUsers", source));

        result.Should().NotBeNull();
        result!.Name.Should().Be("UserGroup");
        result.Members.Should().HaveCount(4);
        result.Members[0].Should().Be(("None",     0L));
        result.Members[1].Should().Be(("Banned",   1L));
        result.Members[2].Should().Be(("Moderator", 2L));
        result.Members[3].Should().Be(("Owner",    3L));
    }

    [Fact]
    public void Extract_EnumWithoutExplicitValues_ReturnsNullValues()
    {
        const string source = """
            public enum Status
            {
                Active,
                Inactive,
                Banned,
            }
            """;

        var result = _sut.Extract("Status", Src("X", source));

        result.Should().NotBeNull();
        result!.Members.Should().HaveCount(3);
        result.Members.All(m => m.Value is null).Should().BeTrue();
    }

    [Fact]
    public void Extract_EnumNotInSource_ReturnsNull()
    {
        const string source = "public class Foo { public int X { get; set; } }";
        _sut.Extract("UserGroup", Src("X", source)).Should().BeNull();
    }

    [Fact]
    public void Extract_NullName_ReturnsNull()
    {
        _sut.Extract(null!, Src("X", "enum Foo {}")).Should().BeNull();
    }

    [Fact]
    public void Extract_EmptyDecompiled_ReturnsNull()
    {
        _sut.Extract("UserGroup", new Dictionary<string, string>()).Should().BeNull();
    }

    [Fact]
    public void Extract_SearchesAllDecompiledSources()
    {
        var decompiled = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["A"] = "public class A { public int X; }",
            ["B"] = "public class B { public enum MyEnum { X = 1, Y = 2 } }",
            ["C"] = "public class C { public int Z; }",
        };

        var result = _sut.Extract("MyEnum", decompiled);
        result.Should().NotBeNull();
        result!.Members.Should().HaveCount(2);
    }

    [Fact]
    public void Extract_DefaultNamespace_IsGeneratedDtos()
    {
        const string source = "public enum Foo { A }";
        var result = _sut.Extract("Foo", Src("X", source));
        result!.Namespace.Should().Be("RustRcon.Generated.Dtos");
    }
}
