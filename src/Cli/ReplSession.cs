using System.Reflection;
using RustRcon.Types;
using RustRcon.Types.Commands.Base;
using Spectre.Console;

namespace RustRcon.Cli;

internal sealed class ReplSession
{
    private readonly RconClient _client;
    private readonly CommandRegistry _registry;
    private readonly InputHandler _input;

    public ReplSession(RconClient client)
    {
        _client = client;
        _registry = new CommandRegistry();
        _input = new InputHandler(_registry);
    }

    public void PrintMessage(string markup) => _input.PrintMessage(markup);

    public async Task RunAsync(CancellationToken cancellation = default)
    {
        _client.OnConsoleMessage += OnConsoleMessage;

        while (!cancellation.IsCancellationRequested)
        {
            string? line;
            try
            {
                line = _input.Read();
            }
            catch
            {
                break;
            }

            if (line is null) break;
            if (string.IsNullOrWhiteSpace(line)) continue;

            var trimmed = line.Trim();
            var firstWord = trimmed.Split(' ')[0].ToLowerInvariant();
            var restOfLine = trimmed.Length > firstWord.Length
                ? trimmed[(firstWord.Length + 1)..].Trim()
                : string.Empty;

            switch (firstWord)
            {
                case "exit" or "quit":
                    AnsiConsole.MarkupLine("[dim]Goodbye.[/]");
                    return;
                case "clear" or "cls":
                    AnsiConsole.Clear();
                    continue;
                case "find":
                    RenderFind(restOfLine);
                    continue;
            }

            await ExecuteAsync(trimmed, cancellation);
        }
    }

    private void OnConsoleMessage(Types.Server.Messages.ConsoleMsg msg)
    {
        _input.PrintMessage($"[dim grey][[server]] {ResponseRenderer.EscapeMarkup(msg.Message)}[/]");
    }

    private async Task ExecuteAsync(string input, CancellationToken cancellation)
    {
        var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var cmdName = parts[0];

        var (meta, ambiguous) = _registry.Resolve(cmdName);

        if (meta is null)
        {
            RenderUnknownCommand(cmdName, ambiguous);
            return;
        }

        var createMethod = meta.Type.GetMethod("Create", BindingFlags.Public | BindingFlags.Static)!;
        var parameters = createMethod.GetParameters();
        var argTokens = parts.Skip(1).ToArray();

        if (argTokens.Length < parameters.Count(p => !p.HasDefaultValue))
        {
            AnsiConsole.MarkupLine($"[yellow]Usage:[/] {FormatUsage(meta, parameters)}");
            return;
        }

        object?[] invokeArgs;
        try
        {
            invokeArgs = BuildArgs(parameters, argTokens);
        }
        catch (FormatException ex)
        {
            AnsiConsole.MarkupLine($"[red]Argument error:[/] {ResponseRenderer.EscapeMarkup(ex.Message)}");
            return;
        }

        var cmd = (BaseCommand)createMethod.Invoke(null, invokeArgs)!;

        try
        {
            await _client.SendCommandAsync(cmd, cancellation);
            ResponseRenderer.Render(cmd);
        }
        catch (OperationCanceledException)
        {
            AnsiConsole.MarkupLine("[yellow]Cancelled.[/]");
        }
        catch (Exception ex)
        {
            AnsiConsole.MarkupLine($"[red]Error:[/] {ResponseRenderer.EscapeMarkup(ex.Message)}");
        }
    }

    private void RenderUnknownCommand(string cmdName, IReadOnlyList<CommandMeta> ambiguous)
    {
        if (ambiguous.Count > 1)
        {
            AnsiConsole.MarkupLine($"[yellow]Ambiguous short name '[bold]{cmdName}[/]'. Did you mean:[/]");

            foreach (var a in ambiguous)
                AnsiConsole.MarkupLine($"  [dim]{a.FullName}[/]");

            return;
        }

        AnsiConsole.MarkupLine($"[red]Unknown command:[/] {ResponseRenderer.EscapeMarkup(cmdName)}");
        var suggestions = _registry.Search(cmdName).Take(5).ToList();
        if (suggestions.Count == 0) return;

        AnsiConsole.Markup("[dim]Did you mean:[/]");
        foreach (var s in suggestions) AnsiConsole.Markup($" [dim]{s.FullName}[/]");
        AnsiConsole.WriteLine();
    }

    private void RenderFind(string query)
    {
        var matches = _registry.Find(query).ToList();

        if (matches.Count == 0)
        {
            AnsiConsole.MarkupLine($"[dim]No commands matching '{ResponseRenderer.EscapeMarkup(query)}'.[/]");
            return;
        }

        if (!string.IsNullOrWhiteSpace(query))
        {
            AnsiConsole.MarkupLine(
                $"[dim]{matches.Count} result(s) for '[bold]{ResponseRenderer.EscapeMarkup(query)}[/]'[/]\n"
            );
        }

        var table = new Table()
            .Border(TableBorder.Simple)
            .BorderColor(Spectre.Console.Color.Grey42)
            .AddColumn(new TableColumn("[bold]Command[/]") { Width = 38 })
            .AddColumn(new TableColumn("[bold]Args[/]") { Width = 22 })
            .AddColumn(new TableColumn("[bold]Description[/]"));

        foreach (var cmd in matches)
            table.AddRow(cmd.FullName, FormatParams(cmd), FormatDescription(cmd));

        AnsiConsole.Write(table);
        AnsiConsole.MarkupLine($"\n[dim]Built-in: [bold]find[/] <query>  [bold]clear[/]  [bold]exit[/][/]\n");
    }

    private static string FormatParams(CommandMeta cmd)
    {
        if (cmd.Parameters.Count == 0)
            return "[dim grey](none)[/]";

        return string.Join(" ", cmd.Parameters.Select(p =>
            p.HasDefaultValue ? $"[dim grey][[{p.Name}]][/]" : $"[dim]{p.Name}[/]")
        );
    }

    private static string FormatDescription(CommandMeta cmd)
    {
        return string.IsNullOrEmpty(cmd.Description)
            ? "[dim grey]—[/]"
            : ResponseRenderer.EscapeMarkup(cmd.Description);
    }

    private static string FormatUsage(CommandMeta meta, ParameterInfo[] parameters)
    {
        var paramList = string.Join(" ", parameters.Select(p =>
            p.HasDefaultValue ? $"[[{p.Name}]]" : $"<{p.Name}:{p.ParameterType.Name}>")
        );

        return $"[bold]{meta.FullName}[/] {paramList}";
    }

    private static object?[] BuildArgs(ParameterInfo[] parameters, string[] tokens)
    {
        int tokenIdx = 0;
        var result = new object?[parameters.Length];

        for (int i = 0; i < parameters.Length; i++)
        {
            var p = parameters[i];

            if (p.ParameterType == typeof(bool) && p.HasDefaultValue)
            {
                result[i] = tokens.Contains($"--{p.Name}", StringComparer.OrdinalIgnoreCase);
                continue;
            }

            result[i] = tokenIdx < tokens.Length
                ? CoerceArg(tokens[tokenIdx++], p.ParameterType, p.Name!)
                : p.DefaultValue;
        }

        return result;
    }

    private static object CoerceArg(string value, Type target, string paramName)
    {
        if (target == typeof(SteamId))
        {
            return !ulong.TryParse(value, out var raw)
                ? throw new FormatException($"'{paramName}' must be a valid Steam 64-bit ID.")
                : new SteamId(raw);
        }

        try
        {
            return Type.GetTypeCode(target) switch
            {
                TypeCode.Int32 => int.Parse(value),
                TypeCode.Int64 => long.Parse(value),
                TypeCode.Single => float.Parse(value),
                TypeCode.Double => double.Parse(value),
                TypeCode.Boolean => bool.Parse(value),
                TypeCode.UInt64 => ulong.Parse(value),
                TypeCode.String => value,
                _ => Convert.ChangeType(value, target),
            };
        }
        catch
        {
            throw new FormatException($"Cannot convert '{value}' to {target.Name} for parameter '{paramName}'.");
        }
    }
}