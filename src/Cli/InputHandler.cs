using System.Reflection;
using System.Text;
using Spectre.Console;

namespace RustRcon.Cli;

/// <summary>
///     Console readline with tab-cycling, ghost-text hints, parameter hints,
///     command history and thread-safe <see cref="PrintMessage"/>.
/// </summary>
internal sealed class InputHandler(CommandRegistry registry)
{
    private readonly StringBuilder _sb = new();
    private readonly Lock _lock = new();
    private readonly List<string> _history = [];

    private int _historyIdx = -1;
    private int _ghostLength;
    private int _inputStartCol;
    private List<string> _tabCandidates = [];
    private int _tabIdx = -1;

    /// <summary>
    ///     Prints <paramref name="markup"/> without corrupting the current input line.
    ///     Safe to call from any thread.
    /// </summary>
    public void PrintMessage(string markup)
    {
        lock (_lock)
        {
            Console.Write("\r\x1b[K");
            AnsiConsole.MarkupLine(markup);
            AnsiConsole.Markup("[bold green]>[/] ");
            
            _inputStartCol = Console.CursorLeft;
            Console.Write(_sb.ToString());
            
            _ghostLength = 0;
            DrawGhost(_sb.ToString());
        }
    }

    /// <summary>Reads a line of input. Returns <see langword="null"/> on Ctrl-C/Ctrl-D.</summary>
    public string? Read()
    {
        lock (_lock)
        {
            AnsiConsole.Markup("[bold green]>[/] ");
            _inputStartCol = Console.CursorLeft;
            _sb.Clear();
            _ghostLength = 0;
            _tabCandidates = [];
            _tabIdx = -1;
        }

        while (true)
        {
            var key = Console.ReadKey(intercept: true);

            lock (_lock)
            {
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                    {
                        ClearGhost();
                        Console.WriteLine();
                        var result = _sb.ToString().Trim();
                        if (result.Length <= 0)
                            return result;

                        _history.Insert(0, result);
                        _historyIdx = -1;
                        return result;
                    }
                    case ConsoleKey.C when key.Modifiers.HasFlag(ConsoleModifiers.Control):
                    case ConsoleKey.D when key.Modifiers.HasFlag(ConsoleModifiers.Control):
                    {
                        ClearGhost();
                        Console.WriteLine("^C");
                        return null;
                    }
                    case ConsoleKey.Escape:
                    {
                        ClearGhost();
                        ReplaceInput(string.Empty);
                        ResetTab();
                        break;
                    }

                    case ConsoleKey.Backspace:
                    {
                        if (_sb.Length == 0)
                            break;

                        ClearGhost();
                        _sb.Remove(_sb.Length - 1, 1);

                        Console.Write("\b \b");

                        ResetTab();
                        DrawGhost(_sb.ToString());
                        break;
                    }

                    case ConsoleKey.Tab:
                    {
                        ClearGhost();
                        HandleTab();
                        break;
                    }

                    case ConsoleKey.UpArrow:
                    {
                        if (_history.Count == 0)
                            break;

                        ClearGhost();
                        ResetTab();

                        _historyIdx = Math.Min(_historyIdx + 1, _history.Count - 1);
                        ReplaceInput(_history[_historyIdx]);
                        break;
                    }

                    case ConsoleKey.DownArrow:
                    {
                        ClearGhost();
                        ResetTab();

                        _historyIdx = Math.Max(_historyIdx - 1, -1);
                        ReplaceInput(_historyIdx >= 0 ? _history[_historyIdx] : string.Empty);
                        break;
                    }
                    default:
                    {
                        if (key.KeyChar is '\0' or '\r' or '\n')
                            break;

                        ClearGhost();
                        ResetTab();

                        _sb.Append(key.KeyChar);
                        Console.Write(key.KeyChar);

                        DrawGhost(_sb.ToString());
                        break;
                    }
                }
            }
        }
    }

    private void ClearGhost()
    {
        if (_ghostLength == 0)
            return;

        var col = Console.CursorLeft;
        var row = Console.CursorTop;

        Console.Write(new string(' ', _ghostLength));
        Console.SetCursorPosition(col, row);
        _ghostLength = 0;
    }

    private void DrawGhost(string input)
    {
        var ghost = ComputeGhost(input);
        if (string.IsNullOrEmpty(ghost))
            return;

        var col = Console.CursorLeft;
        var row = Console.CursorTop;

        Console.Write($"\x1b[2m{ghost}\x1b[0m");
        Console.SetCursorPosition(col, row);
        _ghostLength = ghost.Length;
    }

    private string ComputeGhost(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return string.Empty;

        var spaceIdx = input.IndexOf(' ');

        if (spaceIdx < 0)
        {
            return TryCompleteFullName(input) ?? TrySuggestAlias(input) ?? string.Empty;
        }

        var (meta, _) = registry.Resolve(input[..spaceIdx]);
        if (meta is null || meta.Parameters.Count == 0) return string.Empty;

        var typedCount = input[(spaceIdx + 1)..].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        var remaining = meta.Parameters.Skip(typedCount).ToList();
        if (remaining.Count == 0) return string.Empty;

        return "  " + string.Join(" ", remaining.Select(FormatParamHint));
    }

    private string? TryCompleteFullName(string input)
    {
        var best = registry.Search(input).FirstOrDefault();

        if (best is null || best.FullName.Length <= input.Length)
            return null;

        return best.FullName[input.Length..];
    }

    private string? TrySuggestAlias(string input)
    {
        var (meta, _) = registry.Resolve(input);

        if (meta is null)
            return null;

        if (!meta.ShortName.Equals(input, StringComparison.OrdinalIgnoreCase))
            return null;

        return string.Equals(meta.FullName, input, StringComparison.Ordinal)
            ? null
            : $"  \x1b[3m→ {meta.FullName}\x1b[0m\x1b[2m";
    }

    private static string FormatParamHint(ParameterInfo p)
    {
        return p.HasDefaultValue ? $"[{p.Name}]" : $"<{p.Name}:{p.ParameterType.Name}>";
    }

    private void HandleTab()
    {
        var current = _sb.ToString();
        if (current.Contains(' ')) return;

        if (_tabCandidates.Count == 0)
        {
            var set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var c in registry.Search(current))
            {
                if (set.Add(c.FullName) && set.Count == 20)
                    break;
            }

            if (set.Count < 20)
            {
                foreach (var c in registry.SearchByShortName(current))
                {
                    if (set.Add(c.FullName) && set.Count == 20)
                        break;
                }
            }

            _tabCandidates = set.ToList();
        }

        if (_tabCandidates.Count == 0) return;

        _tabIdx = (_tabIdx + 1) % _tabCandidates.Count;
        ReplaceInput(_tabCandidates[_tabIdx] + " ");
        DrawGhost(_sb.ToString());
    }

    private void ResetTab()
    {
        _tabCandidates = [];
        _tabIdx = -1;
    }

    private void ReplaceInput(string text)
    {
        var backCount = Console.CursorLeft - _inputStartCol;
        if (backCount > 0)
        {
            Console.Write(new string('\b', backCount));
            Console.Write(new string(' ', backCount));
            Console.Write(new string('\b', backCount));
        }

        _sb.Clear();
        _sb.Append(text);
        if (text.Length > 0) Console.Write(text);
    }
}