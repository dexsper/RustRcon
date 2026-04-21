using RustRcon.Types;
using Spectre.Console;

namespace RustRcon.Cli;

internal sealed class CliLogger : ILogger
{
    private Action<string>? _print;

    /// <summary>
    ///     Redirects all future log output through <paramref name="print"/> so messages
    ///     are printed without overwriting the active input line.
    /// </summary>
    public void Attach(Action<string> print) => _print = print;

    public void Log(string message)
    {
        var markup = $"[dim grey][[rcon]] {ResponseRenderer.EscapeMarkup(message)}[/]";

        if (_print is not null)
        {
            _print(markup);
            return;
        }

        AnsiConsole.MarkupLine(markup);
    }
}