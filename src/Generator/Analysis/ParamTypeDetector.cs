using System.Text.RegularExpressions;
using RustRcon.Generator.Analysis.Models;

namespace RustRcon.Generator.Analysis;

/// <summary>
///     Determines the parameter types a command expects by collecting every
///     <c>arg.Get*(index, …)</c> call in the <c>Call</c> delegate body (or in
///     the implementation method it proxies to), ordered by their positional
///     index.
/// </summary>
public static class ParamTypeDetector
{
    private const string MinSteamIdLiteral = "70000000000000000";
    private const string MinSteamIdLiteralSpaced = "70_000_000_000_000_000";

    // Captures an optional variable assignment followed by an arg.Get* call:
    //   int num = arg.GetInt(0, 50)   →  varName="num", method="GetInt", index="0"
    //   arg.GetFloat(1)               →  varName="",    method="GetFloat", index="1"
    private static readonly Regex GetArgPattern = new(
        @"(?:[\w.<>\[\]?]+\s+(\w+)\s*=\s*)?arg\.(GetInt|GetFloat|GetBool|GetString|GetUInt64|GetULong|GetLong)\((\d+)",
        RegexOptions.Compiled);

    // Captures: arg.HasArg("--json")  →  group 1 = "--json"
    private static readonly Regex HasArgPattern = new(
        @"arg\.HasArg\(""([^""]+)""\)",
        RegexOptions.Compiled);

    // Matches calls like "Admin.removeowner(arg)" to trace into referenced methods.
    private static readonly Regex DelegateCallPattern = new(
        @"(\w+)\.(\w+)\(arg\)",
        RegexOptions.Compiled);

    /// <summary>
    ///     Returns all parameters detected in the <c>Call</c> delegate body (or
    ///     in the referenced implementation method), sorted by their positional
    ///     index. Returns an empty list when no typed parameters are found.
    /// </summary>
    /// <param name="callBody">Raw <c>Call</c> delegate body text.</param>
    /// <param name="decompiled">
    ///     Decompiled source of implementation classes, keyed by simple name
    ///     (e.g. <c>"Admin"</c>).
    /// </param>
    public static IReadOnlyList<CommandParameter> Detect(
        string? callBody,
        IReadOnlyDictionary<string, string> decompiled)
    {
        if (string.IsNullOrWhiteSpace(callBody))
            return [];

        var direct = CollectFromBody(callBody);
        if (direct.Count > 0)
            return direct;

        var match = DelegateCallPattern.Match(callBody);
        while (match.Success)
        {
            var className = match.Groups[1].Value;
            var methodName = match.Groups[2].Value;

            if (decompiled.TryGetValue(className, out var source))
            {
                var result = CollectFromMethod(source, methodName);
                if (result.Count > 0)
                    return result;
            }

            match = match.NextMatch();
        }

        return [];
    }

    /// <summary>
    ///     Collects every <c>arg.Get*(index, …)</c> call in <paramref name="body"/>,
    ///     de-duplicated by index and sorted by it.
    /// </summary>
    public static IReadOnlyList<CommandParameter> CollectFromBody(string body)
    {
        bool isSteamIdCtx =
            body.Contains(MinSteamIdLiteral, StringComparison.Ordinal) ||
            body.Contains(MinSteamIdLiteralSpaced, StringComparison.Ordinal);

        var allMatches = GetArgPattern.Matches(body);
        var byIndex = new SortedDictionary<int, CommandParameter>();

        foreach (Match m in allMatches)
        {
            if (!int.TryParse(m.Groups[3].Value, out int idx)) continue;
            if (byIndex.ContainsKey(idx)) continue;

            var varName = m.Groups[1].Success && m.Groups[1].Value.Length > 0
                ? m.Groups[1].Value
                : null;
            var method = m.Groups[2].Value;
            var typeName = MethodToTypeName(method, isSteamIdCtx);

            // SteamId always uses "steamId" regardless of the local variable name,
            // since decompiler output often uses cryptic names like "uInt".
            var paramName = typeName == "SteamId"
                ? "steamId"
                : varName is not null
                    ? SanitiseName(varName)
                    : FallbackName(typeName, idx, allMatches.Count);

            byIndex[idx] = new CommandParameter
            {
                TypeName = typeName,
                ParameterName = paramName,
            };
        }

        var positional = byIndex.Values.ToList();

        var seen = new HashSet<string>(StringComparer.Ordinal);
        var flags = new List<CommandParameter>();
        foreach (Match m in HasArgPattern.Matches(body))
        {
            var rawFlag = m.Groups[1].Value;
            var paramName = rawFlag.TrimStart('-');
            if (string.IsNullOrEmpty(paramName) || !seen.Add(rawFlag)) continue;

            flags.Add(new CommandParameter
            {
                TypeName = "bool",
                ParameterName = SanitiseName(paramName),
                FlagName = rawFlag,
            });
        }

        if (flags.Count == 0) return positional;

        var combined = new List<CommandParameter>(positional.Count + flags.Count);
        combined.AddRange(positional);
        combined.AddRange(flags);
        return combined;
    }

    private static IReadOnlyList<CommandParameter> CollectFromMethod(
        string classSource, string methodName)
    {
        var idx = classSource.IndexOf($" {methodName}(", StringComparison.Ordinal);

        if (idx < 0)
            idx = classSource.IndexOf($"\t{methodName}(", StringComparison.Ordinal);

        if (idx < 0)
            return [];

        int braceOpen = classSource.IndexOf('{', idx);
        return braceOpen < 0 ? [] : CollectFromBody(ExtractBody(classSource, braceOpen));
    }

    private static string MethodToTypeName(string getMethod, bool isSteamIdCtx) => getMethod switch
    {
        "GetInt" => "int",
        "GetFloat" => "float",
        "GetBool" => "bool",
        "GetString" => "string",
        "GetULong" => "ulong",
        "GetLong" => "long",
        "GetUInt64" => isSteamIdCtx ? "SteamId" : "ulong",
        _ => "string",
    };

    /// <summary>Fallback parameter name when no variable name is available.</summary>
    private static string FallbackName(string typeName, int index, int total) => total == 1
        ? typeName switch
        {
            "SteamId" => "steamId",
            "string" => "args",
            _ => "value",
        }
        : $"arg{index}";

    /// <summary>Renames decompiler-generated names that clash with C# keywords.</summary>
    private static string SanitiseName(string name) =>
        name is "string" or "int" or "float" or "bool" or "object" or "var" or "event" or "ref"
            ? "@" + name
            : name;

    /// <summary>Extracts the body between matching braces starting at <paramref name="openBrace"/>.</summary>
    private static string ExtractBody(string source, int openBrace)
    {
        int depth = 0, end = openBrace;
        for (int i = openBrace; i < source.Length && i < openBrace + 4000; i++)
        {
            if (source[i] == '{')
            {
                depth++;
                continue;
            }

            if (source[i] != '}')
                continue;

            depth--;
            if (depth != 0)
                continue;

            end = i;
            break;
        }

        return source[openBrace..end];
    }
}