using FluentAssertions;
using RustRcon.Generator.Analysis;

namespace RustRcon.Generator.Tests.Analysis;

public sealed class ReturnTypeDetectorTests
{
    [Fact]
    public void Detect_NoReplyWithObject_ReturnsNull()
    {
        const string body = "{ Admin.say(arg); }";
        ReturnTypeDetector.Detect(body).Should().BeNull();
    }

    [Fact]
    public void Detect_NullBody_ReturnsNull()
    {
        ReturnTypeDetector.Detect(null).Should().BeNull();
    }

    [Fact]
    public void Detect_EmptyBody_ReturnsNull()
    {
        ReturnTypeDetector.Detect(string.Empty).Should().BeNull();
    }

    [Fact]
    public void Detect_IntReturnType()
    {
        const string body = @"
{
    int num = BaseBoat.seconds_between_shore_drift(arg);
    arg.ReplyWithObject(num);
}";
        ReturnTypeDetector.Detect(body).Should().Be("int");
    }

    [Fact]
    public void Detect_PlayerInfoArrayReturnType()
    {
        const string body = @"
{
    Admin.PlayerInfo[] rval = Admin.playerlist(arg);
    arg.ReplyWithObject(rval);
}";
        ReturnTypeDetector.Detect(body).Should().Be("PlayerInfo[]");
    }

    [Fact]
    public void Detect_ServerInfoOutputReturnType()
    {
        const string body = @"
{
    Admin.ServerInfoOutput serverInfoOutput = Admin.ServerInfo();
    arg.ReplyWithObject(serverInfoOutput);
}";
        var result = ReturnTypeDetector.Detect(body);
        result.Should().Be("ServerInfoOutput");
    }

    [Fact]
    public void Detect_IEnumerableReturnType_NormalisesToArray()
    {
        // Output.Entry is normalised to ConsoleEntry to avoid namespace qualifier issues.
        const string body = @"
{
    IEnumerable<Output.Entry> rval = ConVar.Console.tail(arg);
    arg.ReplyWithObject(rval);
}";
        var result = ReturnTypeDetector.Detect(body);
        result.Should().Be("ConsoleEntry[]");
    }

    [Fact]
    public void Detect_StringReturnType()
    {
        const string body = @"
{
    string rval = Admin.teaminfo(arg);
    arg.ReplyWithObject(rval);
}";
        ReturnTypeDetector.Detect(body).Should().Be("string");
    }

    [Fact]
    public void Detect_TextTableWithJsonFlag_ReturnsTextTableResponse()
    {
        const string body = @"
{
    bool flag = arg.HasArg(""--json"");
    using TextTable textTable = Facepunch.Pool.Get<TextTable>();
    textTable.ShouldPadColumns = !flag;
    textTable.AddColumns(""EntityId"", ""Position"", ""Authed"");
    foreach (BuildingPrivlidge item in BaseNetworkable.serverEntities.OfType<BuildingPrivlidge>())
    {
        textTable.AddRow(item.net.ID.ToString(), item.transform.position.ToString(), item.authorizedPlayers.Count.ToString());
    }
    arg.ReplyWith(flag ? textTable.ToJson() : textTable.ToString());
}";
        ReturnTypeDetector.Detect(body).Should().Be("TextTableResponse");
    }

    [Fact]
    public void Detect_TextTableWithoutJsonFlag_ReturnsTextTableResponse()
    {
        const string body = @"
{
    using TextTable textTable = Facepunch.Pool.Get<TextTable>();
    textTable.AddColumns(""Name"", ""Value"");
    textTable.AddRow(""foo"", ""bar"");
    arg.ReplyWith(textTable.ToString());
}";
        ReturnTypeDetector.Detect(body).Should().Be("TextTableResponse");
    }

    [Fact]
    public void Detect_TextTableWithoutReplyWith_ReturnsNull()
    {
        // TextTable is created but result is not sent via ReplyWith → no return type.
        const string body = @"
{
    using TextTable textTable = Facepunch.Pool.Get<TextTable>();
    textTable.AddColumns(""A"");
    Debug.Log(textTable.ToString());
}";
        ReturnTypeDetector.Detect(body).Should().BeNull();
    }

    [Fact]
    public void Detect_ReplyWithWithoutTextTable_ReturnsNull()
    {
        // Plain arg.ReplyWith with a string literal — not a TextTable response.
        const string body = @"
{
    arg.ReplyWith(""ok"");
}";
        ReturnTypeDetector.Detect(body).Should().BeNull();
    }

    [Fact]
    public void Detect_DelegateCall_FollowsIntoReferencedMethod()
    {
        // ConsoleGen body just delegates: Server.listtoolcupboards(arg)
        // The actual TextTable logic lives inside ConVar.Server source.
        const string callBody = "{ Server.listtoolcupboards(arg); }";
        const string serverSource = @"
public static void listtoolcupboards(Arg arg)
{
    bool flag = arg.HasArg(""--json"");
    using TextTable textTable = Facepunch.Pool.Get<TextTable>();
    textTable.AddColumns(""EntityId"", ""Position"", ""Authed"");
    arg.ReplyWith(flag ? textTable.ToJson() : textTable.ToString());
}";
        var decompiled = new Dictionary<string, string>
        {
            ["Server"] = serverSource,
        };

        ReturnTypeDetector.Detect(callBody, decompiled).Should().Be("TextTableResponse");
    }

    [Fact]
    public void Detect_DelegateCall_NoMatchInReferencedMethod_ReturnsNull()
    {
        const string callBody    = "{ Server.say(arg); }";
        const string serverSource = @"
public static void say(Arg arg)
{
    Admin.say(arg);
}";
        var decompiled = new Dictionary<string, string>
        {
            ["Server"] = serverSource,
        };

        ReturnTypeDetector.Detect(callBody, decompiled).Should().BeNull();
    }

    [Fact]
    public void Detect_TextTableTakesPrecedenceOverReplyWithObject()
    {
        // TextTable + ReplyWith is detected first even if ReplyWithObject also appears.
        const string body = @"
{
    bool flag = arg.HasArg(""--json"");
    using TextTable textTable = Facepunch.Pool.Get<TextTable>();
    textTable.AddColumns(""X"");
    arg.ReplyWith(flag ? textTable.ToJson() : textTable.ToString());
    arg.ReplyWithObject(null);
}";
        ReturnTypeDetector.Detect(body).Should().Be("TextTableResponse");
    }
}
