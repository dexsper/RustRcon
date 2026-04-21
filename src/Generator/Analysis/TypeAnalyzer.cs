using System.Text.RegularExpressions;
using RustRcon.Generator.Analysis.Models;

namespace RustRcon.Generator.Analysis;

/// <summary>
///     Orchestrates type analysis of all <see cref="CommandDefinition"/> instances:
///     classifies each command, extracts DTO and enum types, and filters player-only commands.
/// </summary>
public sealed class TypeAnalyzer
{
    private static readonly HashSet<string> Primitives = new(StringComparer.Ordinal)
    {
        "string", "int", "long", "float", "double", "bool", "ulong",
        "String", "Int32", "Int64", "Single", "Double", "Boolean", "UInt64",
        "object", "void",
        "TextTableResponse",
    };

    private readonly DtoExtractor  _dtoExtractor  = new();
    private readonly EnumExtractor _enumExtractor = new();

    /// <summary>
    ///     Analyses all <paramref name="commands"/>, enriches them in place, and
    ///     returns de-duplicated maps of required DTOs and enums.
    /// </summary>
    public (Dictionary<string, DtoDefinition> Dtos, Dictionary<string, EnumDefinition> Enums) Analyse(
        IReadOnlyList<CommandDefinition> commands,
        IReadOnlyDictionary<string, string> decompiled)
    {
        var dtos  = new Dictionary<string, DtoDefinition>(StringComparer.Ordinal);
        var enums = new Dictionary<string, EnumDefinition>(StringComparer.Ordinal);

        foreach (var cmd in commands)
            AnalyseCommand(cmd, decompiled, dtos);

        foreach (var dto in dtos.Values)
        foreach (var field in dto.Fields)
        {
            var baseType = field.TypeName.TrimEnd('[', ']').TrimEnd('?');
            if (!Primitives.Contains(baseType) &&
                !dtos.ContainsKey(baseType)    &&
                !enums.ContainsKey(baseType))
            {
                var enumDef = _enumExtractor.Extract(baseType, decompiled);
                if (enumDef is not null)
                    enums[baseType] = enumDef;
            }
        }

        return (dtos, enums);
    }

    private void AnalyseCommand(
        CommandDefinition cmd,
        IReadOnlyDictionary<string, string> decompiled,
        Dictionary<string, DtoDefinition> dtos)
    {
        if (cmd.Variable)
        {
            cmd.Kind           = CommandKind.ConVar;
            cmd.ConVarTypeName = ConVarTypeDetector.Detect(cmd.SetOverrideBody);
            return;
        }

        if (IsPlayerOnlyCommand(cmd, decompiled))
        {
            cmd.RequiresPlayer = true;
            cmd.Kind           = CommandKind.Unknown;
            return;
        }

        var returnType = ReturnTypeDetector.Detect(cmd.CallBody, decompiled);
        if (returnType is not null && TrySetReturnType(cmd, returnType, decompiled, dtos))
            return;

        var @params = ParamTypeDetector.Detect(cmd.CallBody, decompiled);
        if (@params.Count > 0)
        {
            cmd.Parameters.AddRange(@params);
            cmd.Kind = @params is [{ TypeName: "SteamId" }] ? CommandKind.CallWithSteamId : CommandKind.CallWithParams;
            return;
        }

        cmd.Kind = CommandKind.CallVoid;
    }

    private bool TrySetReturnType(
        CommandDefinition cmd,
        string returnType,
        IReadOnlyDictionary<string, string> decompiled,
        Dictionary<string, DtoDefinition> dtos)
    {
        var dto = _dtoExtractor.Extract(returnType, decompiled);
        if (dto is not null)
        {
            cmd.Kind           = CommandKind.CallWithReturn;
            cmd.ReturnTypeName = returnType;
            dtos.TryAdd(dto.Name, dto);
        }
        else if (IsPrimitiveOrCollection(returnType))
        {
            cmd.Kind           = CommandKind.CallWithReturn;
            cmd.ReturnTypeName = returnType;
        }
        else
        {
            return false;
        }

        cmd.Parameters.AddRange(ParamTypeDetector.Detect(cmd.CallBody, decompiled));
        return true;
    }

    private static bool IsPrimitiveOrCollection(string typeName)
    {
        var baseType = typeName.TrimEnd('?').TrimEnd(']', '[');
        return Primitives.Contains(baseType);
    }

    private static bool IsPlayerOnlyCommand(
        CommandDefinition cmd,
        IReadOnlyDictionary<string, string> decompiled)
    {
        if (cmd.CallBody is null) return false;

        if (ContainsPlayerAccess(cmd.CallBody)) return true;

        var match = DelegateCallPattern.Match(cmd.CallBody);
        while (match.Success)
        {
            if (decompiled.TryGetValue(match.Groups[1].Value, out var src))
            {
                var body = ExtractMethodBody(src, match.Groups[2].Value);
                if (body is not null && ContainsPlayerAccess(body)) return true;
            }
            match = match.NextMatch();
        }

        return false;
    }

    private static bool ContainsPlayerAccess(string body) =>
        body.Contains("ArgEx.Player(",  StringComparison.Ordinal) ||
        body.Contains("arg.Player(",    StringComparison.Ordinal) ||
        body.Contains(".GetPlayer(",    StringComparison.Ordinal);

    private static readonly Regex DelegateCallPattern = new(
        @"(\w+)\.(\w+)\(arg\)", RegexOptions.Compiled);

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
            if (classSource[i] == '{') depth++;
            else if (classSource[i] == '}')
            {
                depth--;
                if (depth == 0) { end = i; break; }
            }
        }
        return classSource[braceOpen..end];
    }
}
