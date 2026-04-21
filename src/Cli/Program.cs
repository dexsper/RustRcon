using RustRcon;
using RustRcon.Cli;
using Spectre.Console;

AnsiConsole.Write(new FigletText("RustRcon")
    .Centered()
    .Color(Color.OrangeRed1)
);

AnsiConsole.MarkupLine("[dim]Remote console for Rust game servers  ·  [bold]find[/] <query> to search commands[/]\n");

var config = ConnectionConfig.FromArgs(args) ?? ConnectionConfig.Prompt();
var logger = new CliLogger();
var client = new RconClient(config.Host, config.Port, config.Password, logger);

try
{
    await AnsiConsole.Status().Spinner(Spinner.Known.Dots).StartAsync(
        $"Connecting to [yellow]{config.Host}:{config.Port}[/]…",
        _ => client.ConnectAsync()
    );
}
catch (Exception ex)
{
    AnsiConsole.MarkupLine($"[red]Connection failed:[/] {ex.Message}");
    return 1;
}

AnsiConsole.MarkupLine(
    $"[green]Connected[/] to [bold]{config.Host}:{config.Port}[/]  —  " +
    $"[dim]↑↓ history  TAB complete  find <query>  exit[/]\n"
);

using var cts = new CancellationTokenSource();
Console.CancelKeyPress += (_, e) =>
{
    e.Cancel = true;
    cts.Cancel();
};

var session = new ReplSession(client);
logger.Attach(session.PrintMessage);
await session.RunAsync(cts.Token);

await client.DisconnectAsync("bye");
return 0;