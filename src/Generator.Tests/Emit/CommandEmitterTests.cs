using FluentAssertions;
using RustRcon.Generator.Analysis.Models;
using RustRcon.Generator.Emit;

namespace RustRcon.Generator.Tests.Emit;

public sealed class CommandEmitterTests : IDisposable
{
    private readonly string _tempDir =
        Path.Combine(Path.GetTempPath(), $"RustRconEmitTest_{Guid.NewGuid():N}");

    public void Dispose()
    {
        if (Directory.Exists(_tempDir))
            Directory.Delete(_tempDir, recursive: true);
    }

    private CommandEmitter CreateEmitter() => new(_tempDir);

    [Fact]
    public void Emit_ConVar_GeneratesCorrectFile()
    {
        var emitter = CreateEmitter();
        var cmd = new CommandDefinition
        {
            FullName       = "adventcalendar.overrideadventcalendarday",
            Parent         = "adventcalendar",
            Name           = "overrideadventcalendarday",
            Variable       = true,
            ServerAdmin    = true,
            Kind           = CommandKind.ConVar,
            ConVarTypeName = "int",
            Description    = "Overrides the advent calendar day.",
        };

        var path = emitter.Emit(cmd);
        var content = File.ReadAllText(path);

        content.Should().Contain("BaseConVarCommand<int>");
        content.Should().Contain("CommandFullName = \"adventcalendar.overrideadventcalendarday\"");
        content.Should().Contain("CreateGet()");
        content.Should().Contain("CreateSet(int value)");
        content.Should().Contain("/// <summary>Overrides the advent calendar day.</summary>");
        content.Should().Contain("namespace RustRcon.Generated.Commands");
        content.Should().Contain("class AdventcalendarOverrideadventcalendardayCommand");
    }

    [Fact]
    public void Emit_CallWithReturn_GeneratesCorrectBaseClass()
    {
        var emitter = CreateEmitter();
        var cmd = new CommandDefinition
        {
            FullName       = "global.serverinfo",
            Parent         = "global",
            Name           = "serverinfo",
            Variable       = false,
            ServerAdmin    = true,
            Kind           = CommandKind.CallWithReturn,
            ReturnTypeName = "ServerInfoOutput",
            Description    = "Get a list of information about the server",
        };

        var path = emitter.Emit(cmd);
        var content = File.ReadAllText(path);

        content.Should().Contain("BaseCallCommand<ServerInfoOutput>");
        content.Should().Contain("Create()");
        content.Should().NotContain("CreateGet");
        content.Should().NotContain("CreateSet");
    }

    [Fact]
    public void Emit_VoidCall_UsesBaseCommand()
    {
        var emitter = CreateEmitter();
        var cmd = new CommandDefinition
        {
            FullName    = "global.restart",
            Parent      = "global",
            Name        = "restart",
            Variable    = false,
            ServerAdmin = true,
            Kind        = CommandKind.CallVoid,
            Description = "Restarts the server.",
        };

        var path = emitter.Emit(cmd);
        var content = File.ReadAllText(path);

        content.Should().Contain(": BaseCommand");
        content.Should().NotContain("BaseCallCommand");
        content.Should().NotContain("BaseConVarCommand");
    }

    [Fact]
    public void Emit_SteamIdCommand_IncludesSteamIdParam()
    {
        var emitter = CreateEmitter();
        var cmd = new CommandDefinition
        {
            FullName    = "global.removeowner",
            Parent      = "global",
            Name        = "removeowner",
            Variable    = false,
            ServerAdmin = true,
            Kind        = CommandKind.CallWithSteamId,
            Parameters  = { new CommandParameter { TypeName = "SteamId", ParameterName = "steamId" } },
        };

        var path = emitter.Emit(cmd);
        var content = File.ReadAllText(path);

        content.Should().Contain("Create(SteamId steamId)");
    }

    [Fact]
    public void Emit_DescriptionIsUsedAsXmlDoc()
    {
        var emitter = CreateEmitter();
        var cmd = new CommandDefinition
        {
            FullName    = "global.say",
            Parent      = "global",
            Name        = "say",
            Kind        = CommandKind.CallVoid,
            Description = "Sends a message in chat",
        };

        var path = emitter.Emit(cmd);
        File.ReadAllText(path).Should().Contain("/// <summary>Sends a message in chat</summary>");
    }

    [Fact]
    public void Emit_NoDescription_UsesFallbackXmlDoc()
    {
        var emitter = CreateEmitter();
        var cmd = new CommandDefinition
        {
            FullName = "server.stop",
            Parent   = "server",
            Name     = "stop",
            Kind     = CommandKind.CallVoid,
        };

        var path = emitter.Emit(cmd);
        File.ReadAllText(path).Should().Contain("/// <summary>");
    }

    [Fact]
    public void Emit_TextTableCommand_GeneratesTextTableResponseBaseClass()
    {
        var emitter = CreateEmitter();
        var cmd = new CommandDefinition
        {
            FullName       = "server.listtoolcupboards",
            Parent         = "server",
            Name           = "listtoolcupboards",
            Variable       = false,
            ServerAdmin    = true,
            Kind           = CommandKind.CallWithReturn,
            ReturnTypeName = "TextTableResponse",
            Description    = "Prints all the Tool Cupboards on the server",
            Parameters     =
            {
                new CommandParameter { TypeName = "bool", ParameterName = "json", FlagName = "--json" },
            },
        };

        var path    = emitter.Emit(cmd);
        var content = File.ReadAllText(path);

        // TextTableResponse → dedicated base class, no generic or extra using needed.
        content.Should().Contain(": BaseTextTableCommand");
        content.Should().NotContain("BaseCallCommand<TextTableResponse>");
        content.Should().NotContain("using RustRcon.Types.Response;");
        content.Should().NotContain("using RustRcon.Generated.Dtos;");
        content.Should().Contain("Create(bool json = false)");
        content.Should().Contain("if (json) content.Append(\" --json\")");
        content.Should().Contain("class ServerListtoolcupboardsCommand");
    }

    [Fact]
    public void Emit_CreatesFileInCorrectSubDirectory()
    {
        var emitter = CreateEmitter();
        var cmd = new CommandDefinition
        {
            FullName = "server.stop",
            Parent   = "server",
            Name     = "stop",
            Kind     = CommandKind.CallVoid,
        };

        var path = emitter.Emit(cmd);
        path.Should().Contain(Path.Combine("Commands", "Server"));
        File.Exists(path).Should().BeTrue();
    }
}
