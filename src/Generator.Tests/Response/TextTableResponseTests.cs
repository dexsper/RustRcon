using RustRcon.Types.Response;

namespace RustRcon.Generator.Tests.Response;

public sealed class TextTableResponseTests
{

    [Fact]
    public void Parse_JsonFormat_PopulatesRawAndRows()
    {
        const string json = """[{"EntityId":"123","Position":"(1, 2, 3)","Authed":"5"},{"EntityId":"456","Position":"(4, 5, 6)","Authed":"3"}]""";

        var result = TextTableResponse.Parse(json);

        result.Raw.Should().Be(json);
        result.Rows.Should().NotBeNull().And.HaveCount(2);
        result.Rows![0]["EntityId"].Should().Be("123");
        result.Rows![0]["Position"].Should().Be("(1, 2, 3)");
        result.Rows![0]["Authed"].Should().Be("5");
        result.Rows![1]["EntityId"].Should().Be("456");
    }

    [Fact]
    public void Parse_EmptyJsonArray_ReturnsEmptyRows()
    {
        const string json = "[]";

        var result = TextTableResponse.Parse(json);

        result.Raw.Should().Be(json);
        result.Rows.Should().BeNullOrEmpty();
    }

    [Fact]
    public void Parse_JsonFormat_ColumnNamesAreKeys()
    {
        const string json = """[{"Name":"shop_a","Position":"(0, 0, 0)"}]""";

        var result = TextTableResponse.Parse(json);

        result.Rows.Should().NotBeNull();
        result.Rows![0].Keys.Should().Contain("Name").And.Contain("Position");
    }

    [Fact]
    public void Parse_TextFormat_PopulatesRawAndRows()
    {
        // Matches the output of TextTable.ToString() with ShouldPadColumns = true.
        // Column "EntityId" has width 8 (title), "Position" width 9, "Authed" width 6.
        const string text =
            "EntityId  Position    Authed  \r\n" +
            "123       (1, 2, 3)   5       \r\n" +
            "456       (4, 5, 6)   3       \r\n";

        var result = TextTableResponse.Parse(text);

        result.Raw.Should().Be(text);
        result.Rows.Should().NotBeNull().And.HaveCount(2);
        result.Rows![0]["EntityId"].Should().Be("123");
        result.Rows![0]["Position"].Should().Be("(1, 2, 3)");
        result.Rows![0]["Authed"].Should().Be("5");
        result.Rows![1]["EntityId"].Should().Be("456");
        result.Rows![1]["Authed"].Should().Be("3");
    }

    [Fact]
    public void Parse_TextFormat_SingleColumn()
    {
        const string text =
            "Name    \r\n" +
            "alpha   \r\n" +
            "beta    \r\n";

        var result = TextTableResponse.Parse(text);

        result.Rows.Should().NotBeNull().And.HaveCount(2);
        result.Rows![0]["Name"].Should().Be("alpha");
        result.Rows![1]["Name"].Should().Be("beta");
    }

    [Fact]
    public void Parse_TextFormat_OnlyHeaderLine_ReturnsNullOrEmptyRows()
    {
        const string text = "EntityId  Position  \r\n";

        var result = TextTableResponse.Parse(text);

        result.Rows.Should().BeNullOrEmpty();
    }

    [Fact]
    public void Parse_TextFormat_TrimsWhitespace()
    {
        const string text =
            "Col1    Col2    \r\n" +
            "  x       y    \r\n";

        var result = TextTableResponse.Parse(text);

        result.Rows.Should().NotBeNull();
        result.Rows![0]["Col1"].Should().Be("x");
        result.Rows![0]["Col2"].Should().Be("y");
    }

    [Fact]
    public void Parse_NullOrWhitespace_ReturnsNullRows()
    {
        TextTableResponse.Parse(string.Empty).Rows.Should().BeNull();
        TextTableResponse.Parse("   ").Rows.Should().BeNull();
    }

    [Fact]
    public void Parse_AlwaysPreservesRawContent()
    {
        const string raw = "anything goes here";

        TextTableResponse.Parse(raw).Raw.Should().Be(raw);
    }
}
