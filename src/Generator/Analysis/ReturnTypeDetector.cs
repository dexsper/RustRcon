using System.Text.RegularExpressions;

namespace RustRcon.Generator.Analysis;

/// <summary>
///     Extracts the C# return type from a <c>Call</c> delegate body that contains
///     <c>arg.ReplyWithObject(…)</c> or a <c>TextTable</c> reply.
///     Follows single-level delegate calls (e.g. <c>Server.listtoolcupboards(arg)</c>)
///     into the decompiled source of the referenced class.
/// </summary>
public static class ReturnTypeDetector
{
    // Matches: "SomeType varName = ...; arg.ReplyWithObject(varName);"
    private static readonly Regex LocalVarPattern = new(
        @"(?<type>[\w.<>\[\],\s]+?)\s+\w+\s*=\s*.+?;\s*arg\.ReplyWithObject\(",
        RegexOptions.Singleline | RegexOptions.Compiled);

    // Matches single-level delegate calls like "Server.listtoolcupboards(arg)".
    private static readonly Regex DelegateCallPattern = new(
        @"(\w+)\.(\w+)\(arg\)", RegexOptions.Compiled);

    /// <summary>
    ///     Returns the detected return type name, or <see langword="null"/> when the body
    ///     has no meaningful return value.
    /// </summary>
    /// <param name="callBody">Raw <c>Call</c> delegate body text.</param>
    /// <param name="decompiled">
    ///     Optional map of decompiled class sources keyed by simple class name.
    ///     When provided, delegate calls such as <c>Server.listtoolcupboards(arg)</c>
    ///     are traced into the referenced implementation method.
    /// </param>
    public static string? Detect(
        string? callBody,
        IReadOnlyDictionary<string, string>? decompiled = null)
    {
        if (string.IsNullOrWhiteSpace(callBody))
            return null;

        var result = DetectInBody(callBody);
        if (result is not null)
            return result;

        if (decompiled is null)
            return null;

        var match = DelegateCallPattern.Match(callBody);
        while (match.Success)
        {
            var className  = match.Groups[1].Value;
            var methodName = match.Groups[2].Value;

            if (decompiled.TryGetValue(className, out var source))
            {
                var body = ExtractMethodBody(source, methodName);
                if (body is not null)
                {
                    result = DetectInBody(body);
                    if (result is not null)
                        return result;
                }
            }

            match = match.NextMatch();
        }

        return null;
    }

    private static string? DetectInBody(string callBody)
    {
        if (callBody.Contains("TextTable", StringComparison.Ordinal) &&
            callBody.Contains("arg.ReplyWith(", StringComparison.Ordinal))
            return "TextTableResponse";

        if (!callBody.Contains("ReplyWithObject", StringComparison.Ordinal))
            return null;

        var match = LocalVarPattern.Match(callBody);
        return match.Success ? NormaliseTypeName(match.Groups["type"].Value) : null;
    }

    /// <summary>Normalises decompiler output back to clean C# type names.</summary>
    private static string NormaliseTypeName(string raw)
    {
        raw = raw.Trim();
        raw = raw.Replace("Admin.", string.Empty);
        raw = raw.Replace("ConVar.", string.Empty);
        raw = raw.Replace("ServerUsers.", string.Empty);
        raw = raw.Replace("Chat.", string.Empty);
        raw = raw.Replace("Output.Entry", "ConsoleEntry");

        var ieMatch = Regex.Match(raw, @"IEnumerable<(.+)>");
        if (ieMatch.Success)
            return ieMatch.Groups[1].Value.Trim() + "[]";

        return raw;
    }

    /// <summary>
    ///     Extracts the brace-delimited body of <paramref name="methodName"/> from
    ///     <paramref name="classSource"/>.
    /// </summary>
    private static string? ExtractMethodBody(string classSource, string methodName)
    {
        var idx = classSource.IndexOf($" {methodName}(", StringComparison.Ordinal);
        if (idx < 0) idx = classSource.IndexOf($"\t{methodName}(", StringComparison.Ordinal);
        if (idx < 0) return null;

        int braceOpen = classSource.IndexOf('{', idx);
        if (braceOpen < 0) return null;

        int depth = 0, end = braceOpen;
        for (int i = braceOpen; i < classSource.Length && i < braceOpen + 4000; i++)
        {
            if (classSource[i] == '{')
            {
                depth++;
                continue;
            }

            if (classSource[i] != '}') 
                continue;
            
            depth--;
            if (depth != 0) continue;
            end = i; break;
        }

        return classSource[braceOpen..end];
    }
}
