using FluentAssertions;
using RustRcon.Generator.Analysis;

namespace RustRcon.Generator.Tests.Analysis;

public sealed class ParamTypeDetectorTests
{
    private static readonly Dictionary<string, string> Empty =
        new(StringComparer.Ordinal);

    [Fact]
    public void Detect_NullBody_ReturnsEmpty()
        => ParamTypeDetector.Detect(null, Empty).Should().BeEmpty();

    [Fact]
    public void Detect_WhitespaceBody_ReturnsEmpty()
        => ParamTypeDetector.Detect("   ", Empty).Should().BeEmpty();

    [Fact]
    public void Detect_NoGetCalls_ReturnsEmpty()
    {
        const string body = "{ Admin.reloadConfig(arg); }";
        const string src  = """
            public static void reloadConfig(Arg arg)
            {
                Server.ReloadConfig();
            }
            """;
        ParamTypeDetector.Detect(body, Decompiled("Admin", src)).Should().BeEmpty();
    }

    [Fact]
    public void Detect_DirectGetFloat_DetectsWithoutTracingMethod()
    {
        // applypuzzleresettime pattern: Call body has arg.GetFloat directly
        const string body = """
            {
                float time = arg.GetFloat(0);
                PuzzleReset[] array = Object.FindObjectsByType<PuzzleReset>();
                for (int i = 0; i < array.Length; i++)
                    array[i].DebugApplyPuzzleResetTime(time);
            }
            """;

        var result = ParamTypeDetector.Detect(body, Empty);
        result.Should().HaveCount(1);
        result[0].TypeName.Should().Be("float");
        result[0].ParameterName.Should().Be("time");
    }

    [Fact]
    public void Detect_DirectGetInt_ReturnsInt()
    {
        const string body = "{ int count = arg.GetInt(0, 10); DoWork(count); }";

        var result = ParamTypeDetector.Detect(body, Empty);
        result.Should().HaveCount(1);
        result[0].TypeName.Should().Be("int");
        result[0].ParameterName.Should().Be("count");
    }

    [Fact]
    public void Detect_DirectGetBool_ReturnsBool()
    {
        const string body = "{ bool flag = arg.GetBool(0); Apply(flag); }";
        var result = ParamTypeDetector.Detect(body, Empty);
        result[0].TypeName.Should().Be("bool");
    }

    [Fact]
    public void Detect_DirectGetString_ReturnsString()
    {
        const string body = "{ string msg = arg.GetString(0); Broadcast(msg); }";
        var result = ParamTypeDetector.Detect(body, Empty);
        result[0].TypeName.Should().Be("string");
        result[0].ParameterName.Should().Be("msg");
    }

    [Fact]
    public void Detect_ViaSingleMethodTrace_FindsGetFloat()
    {
        const string body = "{ Debugging.applyPuzzleResetTime(arg); }";
        const string src  = """
            public static void applyPuzzleResetTime(Arg arg)
            {
                float time = arg.GetFloat(0);
                PuzzleReset[] array = Object.FindObjectsByType<PuzzleReset>();
                for (int i = 0; i < array.Length; i++)
                    array[i].DebugApplyPuzzleResetTime(time);
            }
            """;

        var result = ParamTypeDetector.Detect(body, Decompiled("Debugging", src));
        result.Should().HaveCount(1);
        result[0].TypeName.Should().Be("float");
        result[0].ParameterName.Should().Be("time");
    }

    [Fact]
    public void Detect_SteamIdViaMethod_ReturnsSteamIdType()
    {
        const string body = "{ Admin.removeowner(arg); }";
        const string src  = """
            public static void removeowner(Arg arg)
            {
                ulong uInt = arg.GetUInt64(0, 0uL);
                if (uInt < 70000000000000000L)
                {
                    arg.ReplyWith("Not a valid Steam64 ID");
                    return;
                }
                ServerUsers.Remove(uInt);
            }
            """;

        var result = ParamTypeDetector.Detect(body, Decompiled("Admin", src));
        result.Should().HaveCount(1);
        result[0].TypeName.Should().Be("SteamId");
        result[0].ParameterName.Should().Be("steamId");
    }

    [Fact]
    public void Detect_GetUInt64WithoutThreshold_ReturnsUlong()
    {
        const string body = "{ SomeClass.doThing(arg); }";
        const string src  = """
            public static void doThing(Arg arg)
            {
                ulong entityId = arg.GetUInt64(0, 0uL);
                ProcessEntity(entityId);
            }
            """;

        var result = ParamTypeDetector.Detect(body, Decompiled("SomeClass", src));
        result[0].TypeName.Should().Be("ulong");
    }

    [Fact]
    public void Detect_GetString_ReturnsStringParam()
    {
        const string body = "{ Admin.say(arg); }";
        const string src  = """
            public static void say(Arg arg)
            {
                string msg = arg.GetString(0);
                ConsoleNetwork.BroadcastToAllClients("chat.say", msg);
            }
            """;

        var result = ParamTypeDetector.Detect(body, Decompiled("Admin", src));
        result[0].TypeName.Should().Be("string");
    }

    [Fact]
    public void Detect_NoDecompiledSource_ReturnsEmpty()
    {
        const string body = "{ Admin.removeowner(arg); }";
        ParamTypeDetector.Detect(body, Empty).Should().BeEmpty();
    }

    [Fact]
    public void Detect_MultipleGetCallsInBody_ReturnsAllInIndexOrder()
    {
        const string body = """
            {
                int num = arg.GetInt(0, 50);
                string name = arg.GetString(1, "water_catcher_small");
                DoThing(num, name);
            }
            """;

        var result = ParamTypeDetector.Detect(body, Empty);
        result.Should().HaveCount(2);
        result[0].TypeName.Should().Be("int");
        result[0].ParameterName.Should().Be("num");
        result[1].TypeName.Should().Be("string");
        result[1].ParameterName.Should().Be("name");
    }

    [Fact]
    public void Detect_MultipleParamsViaMethod_ReturnsAll()
    {
        const string body = "{ SomeClass.bench(arg); }";
        const string src  = """
            public static void bench(Arg arg)
            {
                int count = arg.GetInt(0, 50);
                string prefab = arg.GetString(1, "water_catcher");
                Spawn(count, prefab);
            }
            """;

        var result = ParamTypeDetector.Detect(body, Decompiled("SomeClass", src));
        result.Should().HaveCount(2);
        result[0].TypeName.Should().Be("int");
        result[0].ParameterName.Should().Be("count");
        result[1].TypeName.Should().Be("string");
        result[1].ParameterName.Should().Be("prefab");
    }

    [Fact]
    public void Detect_ThreeParams_ReturnsAllSortedByIndex()
    {
        const string body = """
            {
                float x = arg.GetFloat(0);
                float y = arg.GetFloat(1);
                float z = arg.GetFloat(2);
                Teleport(x, y, z);
            }
            """;

        var result = ParamTypeDetector.Detect(body, Empty);
        result.Should().HaveCount(3);
        result.All(p => p.TypeName == "float").Should().BeTrue();
        result[0].ParameterName.Should().Be("x");
        result[1].ParameterName.Should().Be("y");
        result[2].ParameterName.Should().Be("z");
    }

    [Fact]
    public void CollectFromBody_EmptyBody_ReturnsEmpty()
        => ParamTypeDetector.CollectFromBody("{ }").Should().BeEmpty();

    [Fact]
    public void CollectFromBody_SteamIdThreshold_ReturnsSteamId()
    {
        const string body = """
            {
                ulong uInt = arg.GetUInt64(0, 0uL);
                if (uInt < 70000000000000000L) { arg.ReplyWith("bad"); return; }
            }
            """;

        var result = ParamTypeDetector.CollectFromBody(body);
        result.Should().HaveCount(1);
        result[0].TypeName.Should().Be("SteamId");
        result[0].ParameterName.Should().Be("steamId");
    }

    [Fact]
    public void CollectFromBody_SteamIdWithSpacedLiteral_ReturnsSteamId()
    {
        const string body = """
            {
                ulong uInt = arg.GetUInt64(0, 0uL);
                if (uInt < 70_000_000_000_000_000) return;
            }
            """;

        var result = ParamTypeDetector.CollectFromBody(body);
        result[0].TypeName.Should().Be("SteamId");
    }

    [Fact]
    public void CollectFromBody_DuplicateIndex_TakesFirstOccurrence()
    {
        const string body = """
            {
                int x = arg.GetInt(0, 1);
                int y = arg.GetInt(0, 2);
            }
            """;

        var result = ParamTypeDetector.CollectFromBody(body);
        result.Should().HaveCount(1);
        result[0].ParameterName.Should().Be("x");
    }

    [Fact]
    public void CollectFromBody_NoVarName_UsesFallbackName()
    {
        const string body = "{ Process(arg.GetInt(0)); }";

        var result = ParamTypeDetector.CollectFromBody(body);
        result.Should().HaveCount(1);
        result[0].TypeName.Should().Be("int");
        result[0].ParameterName.Should().Be("value");
    }

    [Fact]
    public void CollectFromBody_SingleStringNoVarName_UsesFallback()
    {
        const string body = "{ Process(arg.GetString(0)); }";
        var result = ParamTypeDetector.CollectFromBody(body);
        result[0].TypeName.Should().Be("string");
        result[0].ParameterName.Should().Be("args");
    }

    [Fact]
    public void CollectFromBody_MultipleParamsNoVarName_UsesIndexedFallback()
    {
        const string body = "{ Process(arg.GetInt(0), arg.GetFloat(1)); }";
        var result = ParamTypeDetector.CollectFromBody(body);
        result.Should().HaveCount(2);
        result[0].ParameterName.Should().Be("arg0");
        result[1].ParameterName.Should().Be("arg1");
    }

    [Fact]
    public void CollectFromBody_HasArgFlag_ReturnsBoolFlagParam()
    {
        const string body = """
            {
                bool flag = arg.HasArg("--json");
                DoWork(flag);
            }
            """;

        var result = ParamTypeDetector.CollectFromBody(body);
        result.Should().HaveCount(1);
        result[0].TypeName.Should().Be("bool");
        result[0].ParameterName.Should().Be("json");
        result[0].IsFlag.Should().BeTrue();
        result[0].FlagName.Should().Be("--json");
    }

    [Fact]
    public void CollectFromBody_MultipleHasArgFlags_ReturnsAll()
    {
        const string body = """
            {
                bool json    = arg.HasArg("--json");
                bool verbose = arg.HasArg("--verbose");
            }
            """;

        var result = ParamTypeDetector.CollectFromBody(body);
        result.Should().HaveCount(2);
        result.Should().OnlyContain(p => p.IsFlag);
        result.Select(p => p.ParameterName).Should().BeEquivalentTo(["json", "verbose"]);
    }

    [Fact]
    public void CollectFromBody_MixedPositionalAndFlag_PositionalFirst()
    {
        const string body = """
            {
                int count    = arg.GetInt(0, 50);
                bool json    = arg.HasArg("--json");
            }
            """;

        var result = ParamTypeDetector.CollectFromBody(body);
        result.Should().HaveCount(2);
        result[0].IsFlag.Should().BeFalse("positional args come first");
        result[0].TypeName.Should().Be("int");
        result[1].IsFlag.Should().BeTrue();
        result[1].ParameterName.Should().Be("json");
    }

    [Fact]
    public void CollectFromBody_HasArgWithoutDashPrefix_UsesFullNameAsParam()
    {
        const string body = "{ bool f = arg.HasArg(\"force\"); }";

        var result = ParamTypeDetector.CollectFromBody(body);
        result.Should().HaveCount(1);
        result[0].ParameterName.Should().Be("force");
        result[0].FlagName.Should().Be("force");
    }

    [Fact]
    public void Detect_HasArgViaReferencedMethod_ReturnsFlagParam()
    {
        const string body = "{ Global.listvendingmachines(arg); }";
        const string src  = """
            public static void listvendingmachines(Arg arg)
            {
                bool flag = arg.HasArg("--json");
                DoStuff(flag);
            }
            """;

        var result = ParamTypeDetector.Detect(body, Decompiled("Global", src));
        result.Should().HaveCount(1);
        result[0].IsFlag.Should().BeTrue();
        result[0].ParameterName.Should().Be("json");
    }

    private static Dictionary<string, string> Decompiled(string key, string source) =>
        new(StringComparer.Ordinal) { [key] = source };
}
