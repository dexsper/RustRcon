using Newtonsoft.Json.Linq;
using RustRcon.Types.Commands.Base;
using RustRcon.Types.Response;
using Spectre.Console;

namespace RustRcon.Cli;

/// <summary>
///     Renders RCON command responses to the terminal using Spectre.Console.
///     <list type="bullet">
///         <item><see cref="BaseTextTableCommand"/> — full Spectre table with borders.</item>
///         <item>JSON array of objects — table with column headers.</item>
///         <item>JSON object — two-column property/value table.</item>
///         <item>Plain text — printed as-is.</item>
///     </list>
/// </summary>
internal static class ResponseRenderer
{
    public static void Render(BaseCommand command)
    {
        if (command is BaseTextTableCommand { Result: { } result })
        {
            RenderTextTable(result);
            return;
        }

        var content = command.ServerResponse?.Content;
        if (string.IsNullOrWhiteSpace(content))
        {
            AnsiConsole.MarkupLine("[dim](no response)[/]");
            return;
        }

        RenderContent(content);
    }

    private static void RenderContent(string content)
    {
        try
        {
            switch (content.AsSpan().TrimStart())
            {
                case { IsEmpty: false } t when t[0] == '[':
                {
                    var arr = JArray.Parse(content);
                    if (arr.Count > 0 && arr[0] is JObject)
                    {
                        RenderJsonArray(arr);
                        return;
                    }

                    break;
                }
                case { IsEmpty: false } t when t[0] == '{':
                {
                    RenderJsonObject(JObject.Parse(content));
                    return;
                }
            }
        }
        catch
        {
            // ignored
        }

        AnsiConsole.MarkupLine(EscapeMarkup(content));
    }

    private static void RenderTextTable(TextTableResponse response)
    {
        if (response.Rows is not { Count: > 0 } rows)
        {
            AnsiConsole.MarkupLine(EscapeMarkup(response.Raw));
            return;
        }

        var columns = rows[0].Keys.ToList();
        var table = BuildTable(columns);

        foreach (var row in rows)
            table.AddRow(columns.Select(c => EscapeMarkup(row.GetValueOrDefault(c, string.Empty))).ToArray());

        AnsiConsole.Write(table);
    }

    private static void RenderJsonArray(JArray arr)
    {
        if (arr[0] is not JObject first)
        {
            AnsiConsole.MarkupLine(EscapeMarkup(arr.ToString()));
            return;
        }

        var cols = first.Properties().Select(p => p.Name).ToList();
        var table = BuildTable(cols);

        foreach (var item in arr.OfType<JObject>())
            table.AddRow(cols.Select(c => EscapeMarkup(item[c]?.ToString() ?? string.Empty)).ToArray());

        AnsiConsole.Write(table);
    }

    private static void RenderJsonObject(JObject obj)
    {
        var table = new Table()
            .Border(TableBorder.Rounded)
            .BorderColor(Color.Grey42)
            .AddColumn(new TableColumn("[bold]Property[/]") { Width = 28 })
            .AddColumn(new TableColumn("[bold]Value[/]"));

        foreach (var (key, value) in obj)
            table.AddRow(EscapeMarkup(key), EscapeMarkup(value?.ToString() ?? "null"));

        AnsiConsole.Write(table);
    }

    private static Table BuildTable(IEnumerable<string> columnNames)
    {
        var table = new Table().Border(TableBorder.Rounded).BorderColor(Color.Grey42);

        foreach (var col in columnNames)
            table.AddColumn(new TableColumn($"[bold]{EscapeMarkup(col)}[/]"));

        return table;
    }

    internal static string EscapeMarkup(string s) => s.Replace("[", "[[").Replace("]", "]]");
}