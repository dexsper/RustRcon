using FluentAssertions;
using RustRcon.Generator.Analysis;

namespace RustRcon.Generator.Tests.Analysis;

/// <summary>
///     Tests for <see cref="ConsoleGenParser"/>.
///     Uses the object-initialiser array format produced by ICSharpCode.Decompiler
///     when all referenced DLLs are available (the primary format), and also tests
///     the sequential-assignment fallback format.
/// </summary>
public sealed class ConsoleGenParserTests
{
    private static readonly ConsoleGenParser Parser = new();

    private const string ConVarObjInit = """
        new ConsoleSystem.Command
        {
            Name = "overrideadventcalendarday",
            Parent = "adventcalendar",
            FullName = "adventcalendar.overrideadventcalendarday",
            ServerAdmin = true,
            Variable = true,
            GetOveride = delegate
            {
                int v = AdventCalendar.overrideAdventCalendarDay;
                return v.ToString();
            },
            SetOveride = delegate(string str)
            {
                AdventCalendar.overrideAdventCalendarDay = StringExtensions.ToInt(str, 0);
            }
        }
        """;

    private const string CallWithReturnObjInit = """
        new ConsoleSystem.Command
        {
            Name = "serverinfo",
            Parent = "global",
            FullName = "global.serverinfo",
            ServerAdmin = true,
            Description = "Get a list of information about the server",
            Variable = false,
            Call = delegate(ConsoleSystem.Arg arg)
            {
                Admin.ServerInfoOutput info = Admin.ServerInfo();
                arg.ReplyWithObject(info);
            }
        }
        """;

    private const string VoidCallObjInit = """
        new ConsoleSystem.Command
        {
            Name = "say",
            Parent = "global",
            FullName = "global.say",
            ServerAdmin = true,
            Description = "Sends a message in chat",
            Variable = false,
            Call = delegate(ConsoleSystem.Arg arg)
            {
                Admin.say(arg);
            }
        }
        """;

    [Fact]
    public void Parse_EmptySource_ReturnsEmptyList()
    {
        Parser.Parse("public static class ConsoleGen { }").Should().BeEmpty();
    }

    [Fact]
    public void Parse_ObjectInit_ConVar_ExtractsAllFields()
    {
        var results = Parser.Parse(WrapArrayInit(ConVarObjInit));
        results.Should().HaveCount(1);

        var cmd = results[0];
        cmd.FullName.Should().Be("adventcalendar.overrideadventcalendarday");
        cmd.Parent.Should().Be("adventcalendar");
        cmd.Name.Should().Be("overrideadventcalendarday");
        cmd.Variable.Should().BeTrue();
        cmd.ServerAdmin.Should().BeTrue();
        cmd.SetOverrideBody.Should().Contain("ToInt");
        cmd.GetOverrideBody.Should().Contain("overrideAdventCalendarDay");
        cmd.CallBody.Should().BeNull();
    }

    [Fact]
    public void Parse_ObjectInit_CallWithReturn_ExtractsBodyAndDescription()
    {
        var results = Parser.Parse(WrapArrayInit(CallWithReturnObjInit));
        results.Should().HaveCount(1);

        var cmd = results[0];
        cmd.FullName.Should().Be("global.serverinfo");
        cmd.Variable.Should().BeFalse();
        cmd.Description.Should().Be("Get a list of information about the server");
        cmd.CallBody.Should().Contain("ReplyWithObject");
        cmd.SetOverrideBody.Should().BeNull();
        cmd.GetOverrideBody.Should().BeNull();
    }

    [Fact]
    public void Parse_ObjectInit_VoidCall_NoGetSetBodies()
    {
        var results = Parser.Parse(WrapArrayInit(VoidCallObjInit));
        results.Should().HaveCount(1);

        var cmd = results[0];
        cmd.FullName.Should().Be("global.say");
        cmd.Variable.Should().BeFalse();
        cmd.SetOverrideBody.Should().BeNull();
        cmd.GetOverrideBody.Should().BeNull();
        cmd.CallBody.Should().Contain("Admin.say(arg)");
    }

    [Fact]
    public void Parse_ObjectInit_MultipleCommands_ReturnsAll()
    {
        var results = Parser.Parse(WrapArrayInit(ConVarObjInit, CallWithReturnObjInit, VoidCallObjInit));
        results.Should().HaveCount(3);
    }

    [Fact]
    public void Parse_ObjectInit_CommandWithoutFullName_IsExcluded()
    {
        const string noFullName = """
            new ConsoleSystem.Command
            {
                Name = "test",
                Variable = false
            }
            """;

        Parser.Parse(WrapArrayInit(noFullName)).Should().BeEmpty();
    }

    [Fact]
    public void Parse_ObjectInit_ServerAdminFalse_ParsesCorrectly()
    {
        const string cmd = """
            new ConsoleSystem.Command
            {
                Name = "testcmd",
                Parent = "test",
                FullName = "test.testcmd",
                ServerAdmin = false,
                Variable = false,
                Call = delegate(ConsoleSystem.Arg arg) { Admin.test(arg); }
            }
            """;

        var results = Parser.Parse(WrapArrayInit(cmd));
        results.Should().HaveCount(1);
        results[0].ServerAdmin.Should().BeFalse();
    }

    [Fact]
    public void Parse_ObjectInit_DirectGetFloatCallBody_IsExtracted()
    {
        const string cmd = """
            new ConsoleSystem.Command
            {
                Name = "applypuzzleresettime",
                Parent = "debug",
                FullName = "debug.applypuzzleresettime",
                ServerAdmin = true,
                Variable = false,
                Call = delegate(ConsoleSystem.Arg arg)
                {
                    float time = arg.GetFloat(0);
                    ApplyReset(time);
                }
            }
            """;

        var results = Parser.Parse(WrapArrayInit(cmd));
        results.Should().HaveCount(1);
        results[0].CallBody.Should().Contain("GetFloat");
    }

    [Fact]
    public void Parse_SequentialAssignment_ConVar_ExtractsAllFields()
    {
        const string stmts = """

            val = new Command();
            val.Name = "overrideadventcalendarday";
            val.Parent = "adventcalendar";
            val.FullName = "adventcalendar.overrideadventcalendarday";
            val.ServerAdmin = true;
            val.Variable = true;
            val.GetOveride = delegate
            {
                int v = AdventCalendar.overrideAdventCalendarDay;
                return v.ToString();
            };
            val.SetOveride = delegate(string str)
            {
                AdventCalendar.overrideAdventCalendarDay = str.ToInt();
            };
            array[0] = val;
            """;

        var results = Parser.Parse(WrapStaticCtor(stmts));
        results.Should().HaveCount(1);
        results[0].Variable.Should().BeTrue();
        results[0].SetOverrideBody.Should().Contain("ToInt");
    }

    [Fact]
    public void Parse_SequentialAssignment_MultipleCommands_ReturnsAll()
    {
        const string twoCommands = """

            val = new Command();
            val.Name = "a";
            val.Parent = "x";
            val.FullName = "x.a";
            val.Variable = false;
            val.Call = delegate(ConsoleSystem.Arg arg) { Admin.a(arg); };
            array[0] = val;
            val = new Command();
            val.Name = "b";
            val.Parent = "x";
            val.FullName = "x.b";
            val.Variable = false;
            val.Call = delegate(ConsoleSystem.Arg arg) { Admin.b(arg); };
            array[1] = val;
            """;

        var results = Parser.Parse(WrapStaticCtor(twoCommands));
        results.Should().HaveCount(2);
        results[0].FullName.Should().Be("x.a");
        results[1].FullName.Should().Be("x.b");
    }

    /// <summary>Wraps command entries in the object-initialiser array field format.</summary>
    private static string WrapArrayInit(params string[] commandEntries)
    {
        var joined = string.Join(",\n", commandEntries);
        return $$"""
            using System;
            public class ConsoleGen
            {
                public static ConsoleSystem.Command[] All = new ConsoleSystem.Command[{{commandEntries.Length}}]
                {
                    {{joined}}
                };
            }
            """;
    }

    /// <summary>Wraps command entries in the sequential-assignment static constructor format.</summary>
    private static string WrapStaticCtor(string stmts) => $$"""
        public class ConsoleGen
        {
            public static Command[] All;
            static ConsoleGen()
            {
                Command[] array = new Command[1898];
                Command val = new Command();
                {{stmts}}
                All = array;
            }
        }
        """;
}
