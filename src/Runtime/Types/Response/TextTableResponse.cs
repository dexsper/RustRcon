using Newtonsoft.Json;

namespace RustRcon.Types.Response;

/// <summary>
///     Structured response from RCON commands that reply with a <c>TextTable</c>.
/// </summary>
/// <remarks>
///     Commands that use <c>TextTable</c> internally accept an optional <c>--json</c> flag.
///     <list type="bullet">
///         <item>
///             <term>Without <c>--json</c></term>
///             <description>
///                 Server replies with a space-padded fixed-width text table.
///                 <see cref="Rows"/> is still populated by parsing the text columns.
///             </description>
///         </item>
///         <item>
///             <term>With <c>--json</c></term>
///             <description>
///                 Server replies with a JSON array where each element is an object whose
///                 keys are the column names. <see cref="Rows"/> is populated from the JSON.
///             </description>
///         </item>
///     </list>
///     <see cref="Raw"/> always contains the original unmodified server response.
/// </remarks>
public sealed class TextTableResponse
{
    /// <summary>The raw server response string — always available regardless of format.</summary>
    public string Raw { get; }

    /// <summary>
    ///     Parsed rows, or <see langword="null"/> when parsing failed.
    ///     Each row maps <em>column name</em> → <em>cell value</em>.
    /// </summary>
    public IReadOnlyList<IReadOnlyDictionary<string, string>>? Rows { get; }

    private TextTableResponse(string raw, IReadOnlyList<IReadOnlyDictionary<string, string>>? rows)
    {
        Raw  = raw;
        Rows = rows;
    }

    public static TextTableResponse Parse(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            return new TextTableResponse(content, null);

        var trimmed = content.AsSpan().TrimStart();

        IReadOnlyList<IReadOnlyDictionary<string, string>>? rows = null;

        if (trimmed.Length > 0 && trimmed[0] == '[')
            rows = TryParseJson(content);
        else
            rows = TryParseText(content);

        return new TextTableResponse(content, rows);
    }

    // ── JSON format ──────────────────────────────────────────────────────────
    // Server output: [{"Col1":"v1","Col2":"v2"},...]

    private static IReadOnlyList<IReadOnlyDictionary<string, string>>? TryParseJson(string content)
    {
        try
        {
            return JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(content);
        }
        catch
        {
            return null;
        }
    }

    // ── Text format ──────────────────────────────────────────────────────────
    // Server output (TextTable.ToString()):
    //
    //   Col1      Col2     Col3
    //   value1    value2   value3
    //   ...
    //
    // Every column occupies exactly (max_content_width + 1) characters, left-aligned,
    // padded with spaces. Column boundaries are inferred from the header line.

    private static IReadOnlyList<IReadOnlyDictionary<string, string>>? TryParseText(string content)
    {
        var lines = content.Split('\n');
        if (lines.Length < 2) return null;

        var headerLine = lines[0].TrimEnd('\r');
        if (string.IsNullOrWhiteSpace(headerLine)) return null;

        var colStarts = FindColumnStarts(headerLine);
        if (colStarts.Length == 0) return null;

        var colNames = new string[colStarts.Length];
        for (int i = 0; i < colStarts.Length; i++)
        {
            var start = colStarts[i];
            var end   = i + 1 < colStarts.Length ? colStarts[i + 1] : headerLine.Length;
            colNames[i] = headerLine[start..Math.Min(end, headerLine.Length)].Trim();
        }

        var rows = new List<IReadOnlyDictionary<string, string>>();
        for (int r = 1; r < lines.Length; r++)
        {
            var line = lines[r].TrimEnd('\r');
            if (string.IsNullOrWhiteSpace(line)) continue;

            var row = new Dictionary<string, string>(colStarts.Length, StringComparer.Ordinal);
            for (int i = 0; i < colStarts.Length; i++)
            {
                var start = colStarts[i];
                if (start >= line.Length)
                {
                    row[colNames[i]] = string.Empty;
                    continue;
                }
                var end = i + 1 < colStarts.Length
                    ? Math.Min(colStarts[i + 1], line.Length)
                    : line.Length;
                row[colNames[i]] = line[start..end].Trim();
            }
            rows.Add(row);
        }

        return rows.Count > 0 ? rows : null;
    }

    /// <summary>
    ///     Returns 0-based positions where each column starts in a fixed-width header line.
    ///     Column 0 always starts at position 0; subsequent columns begin at the first
    ///     non-space character that follows a run of spaces.
    /// </summary>
    private static int[] FindColumnStarts(string headerLine)
    {
        var starts    = new List<int> { 0 };
        bool prevSpace = false;

        for (int i = 1; i < headerLine.Length; i++)
        {
            bool isSpace = headerLine[i] == ' ';
            if (!isSpace && prevSpace)
                starts.Add(i);
            prevSpace = isSpace;
        }

        return starts.ToArray();
    }
}
