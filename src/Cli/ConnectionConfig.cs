using Spectre.Console;

namespace RustRcon.Cli;

internal sealed class ConnectionConfig
{
    public required string Host { get; init; }
    public required int Port { get; init; }
    public required string Password { get; init; }

    /// <summary>Tries to parse --host, --port, --password from argv. Returns null if any are missing.</summary>
    public static ConnectionConfig? FromArgs(string[] args)
    {
        string? host = null;
        int? port = null;
        string? pass = null;

        for (int i = 0; i < args.Length - 1; i++)
        {
            switch (args[i])
            {
                case "--host" or "-h": host = args[++i]; break;
                case "--port" or "-p": port = int.TryParse(args[++i], out var p) ? p : null; break;
                case "--password" or "--pass": pass = args[++i]; break;
            }
        }

        return host is null || port is null || pass is null
            ? null
            : new ConnectionConfig { Host = host, Port = port.Value, Password = pass };
    }

    /// <summary>Interactively prompts the user for the three required values.</summary>
    public static ConnectionConfig Prompt()
    {
        var host = AnsiConsole.Ask("Server [green]host[/]:", "127.0.0.1");
        var port = AnsiConsole.Ask("RCON [green]port[/]:", 28016);
        var pass = AnsiConsole.Prompt(new TextPrompt<string>("RCON [green]password[/]:").Secret());

        return new ConnectionConfig { Host = host, Port = port, Password = pass };
    }
}