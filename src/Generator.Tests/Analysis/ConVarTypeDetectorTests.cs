using FluentAssertions;
using RustRcon.Generator.Analysis;

namespace RustRcon.Generator.Tests.Analysis;

public sealed class ConVarTypeDetectorTests
{
    [Theory]
    [InlineData("AdventCalendar.overrideAdventCalendarDay = str.ToInt();", "int")]
    [InlineData("SomeClass.field = StringExtensions.ToInt(str);",          "int")]
    [InlineData("SomeClass.value = str.ToFloat();",                        "float")]
    [InlineData("SomeClass.value = StringExtensions.ToFloat(str);",        "float")]
    [InlineData("SomeClass.flag = str.ToBool();",                          "bool")]
    [InlineData("SomeClass.flag = StringExtensions.ToBool(str);",          "bool")]
    [InlineData("BoomBox.ServerUrlList = str;",                            "string")]
    [InlineData("",                                                         "string")]
    [InlineData(null,                                                       "string")]
    public void Detect_ReturnsCorrectType(string? body, string expectedType)
    {
        var result = ConVarTypeDetector.Detect(body);
        result.Should().Be(expectedType);
    }

    [Fact]
    public void Detect_ToLong_ReturnsLong()
    {
        var result = ConVarTypeDetector.Detect("SomeClass.field = str.ToLong();");
        result.Should().Be("long");
    }

    [Fact]
    public void Detect_WhitespaceBody_ReturnsString()
    {
        var result = ConVarTypeDetector.Detect("   ");
        result.Should().Be("string");
    }
}
