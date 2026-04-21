using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RustRcon.Generator.Analysis.Models;

namespace RustRcon.Generator.Analysis;

/// <summary>
///     Parses the decompiled <c>ConsoleGen</c> C# source and extracts a
///     <see cref="CommandDefinition"/> for every entry in the <c>All</c> command
///     table.
///     <para>
///         When all managed DLLs are present, <c>ICSharpCode.Decompiler</c> produces
///         clean object-initialiser syntax:
///         <code>
///         public static ConsoleSystem.Command[] All = new ConsoleSystem.Command[N]
///         {
///             new ConsoleSystem.Command { Name = "…", GetOveride = delegate { … }, … },
///             …
///         };
///         </code>
///     </para>
///     <para>
///         When dependency DLLs are absent the decompiler falls back to sequential
///         property assignments inside a static constructor. The parser handles both
///         forms.
///     </para>
/// </summary>
public sealed class ConsoleGenParser
{
    /// <summary>Parses <paramref name="source"/> and returns all discovered command definitions.</summary>
    public IReadOnlyList<CommandDefinition> Parse(string source)
    {
        var tree = CSharpSyntaxTree.ParseText(source);
        var root = tree.GetRoot();

        var results = TryParseArrayInitialiser(root);
        if (results.Count > 0) return results;

        var staticCtor = root.DescendantNodes()
            .OfType<ConstructorDeclarationSyntax>()
            .FirstOrDefault(c => c.Modifiers.Any(m => m.RawKind == (int)SyntaxKind.StaticKeyword));

        return staticCtor?.Body is null
            ? Array.Empty<CommandDefinition>()
            : ParseSequentialAssignments(staticCtor.Body);
    }

    private static IReadOnlyList<CommandDefinition> TryParseArrayInitialiser(SyntaxNode root)
    {
        var allDeclarator = root.DescendantNodes()
            .OfType<VariableDeclaratorSyntax>()
            .FirstOrDefault(v => v.Identifier.Text == "All");

        IEnumerable<ExpressionSyntax>? elements = allDeclarator?.Initializer?.Value switch
        {
            ArrayCreationExpressionSyntax arrayCreation => arrayCreation.Initializer?.Expressions,
            ImplicitArrayCreationExpressionSyntax @implicit => @implicit.Initializer.Expressions,
            _ => null
        };

        if (elements is null) return Array.Empty<CommandDefinition>();

        var results = new List<CommandDefinition>();
        foreach (var expr in elements)
        {
            if (expr is not ObjectCreationExpressionSyntax obj || obj.Initializer is null)
                continue;

            var map = BuildMap(obj.Initializer);
            var def = Build(map);
            if (!string.IsNullOrEmpty(def.FullName))
                results.Add(def);
        }

        return results;
    }

    /// <summary>
    ///     Builds a property map from an object initialiser expression:
    ///     <c>{ Name = "…", Parent = "…", … }</c>.
    /// </summary>
    private static Dictionary<string, ExpressionSyntax> BuildMap(InitializerExpressionSyntax init)
    {
        var map = new Dictionary<string, ExpressionSyntax>(StringComparer.Ordinal);
        foreach (var expr in init.Expressions)
        {
            if (expr is AssignmentExpressionSyntax { Left: IdentifierNameSyntax name } assignment)
                map[name.Identifier.Text] = assignment.Right;
        }

        return map;
    }

    private static IReadOnlyList<CommandDefinition> ParseSequentialAssignments(BlockSyntax body)
    {
        var results = new List<CommandDefinition>();
        Dictionary<string, ExpressionSyntax>? current = null;

        foreach (var stmt in body.Statements)
        {
            if (stmt is not ExpressionStatementSyntax exprStmt) continue;
            var expr = exprStmt.Expression;

            if (IsNewCommand(expr))
            {
                if (current is not null)
                {
                    var def = Build(current);
                    if (!string.IsNullOrEmpty(def.FullName)) results.Add(def);
                }

                current = new Dictionary<string, ExpressionSyntax>(StringComparer.Ordinal);
                continue;
            }

            if (current is not null &&
                expr is AssignmentExpressionSyntax { Left: MemberAccessExpressionSyntax member } assign)
            {
                current[member.Name.Identifier.Text] = assign.Right;
            }
        }

        if (current is null) return results;

        var finalDef = Build(current);
        if (!string.IsNullOrEmpty(finalDef.FullName)) results.Add(finalDef);

        return results;
    }

    private static bool IsNewCommand(ExpressionSyntax expr)
    {
        return expr is AssignmentExpressionSyntax
        {
            Right: ObjectCreationExpressionSyntax creation
        } && creation.Type.ToString() is "Command" or "ConsoleSystem.Command";
    }

    private static CommandDefinition Build(Dictionary<string, ExpressionSyntax> map)
    {
        return new()
        {
            FullName = GetString(map, "FullName"),
            Parent = GetString(map, "Parent"),
            Name = GetString(map, "Name"),
            Variable = GetBool(map, "Variable"),
            ServerAdmin = GetBool(map, "ServerAdmin"),
            RconOnly = GetBool(map, "RconOnly"),
            Saved = GetBool(map, "Saved"),
            Replicated = GetBool(map, "Replicated"),
            Description = GetString(map, "Description"),
            SetOverrideBody = GetDelegateBody(map, "SetOveride"),
            GetOverrideBody = GetDelegateBody(map, "GetOveride"),
            CallBody = GetDelegateBody(map, "Call"),
        };
    }

    private static string GetString(Dictionary<string, ExpressionSyntax> map, string key)
    {
        if (!map.TryGetValue(key, out var expr)) return string.Empty;
        return expr switch
        {
            LiteralExpressionSyntax lit when lit.Kind() == SyntaxKind.StringLiteralExpression
                => lit.Token.ValueText,
            InterpolatedStringExpressionSyntax interp
                => interp.Contents.ToString(),
            _ => string.Empty
        };
    }

    private static bool GetBool(Dictionary<string, ExpressionSyntax> map, string key)
    {
        if (!map.TryGetValue(key, out var expr)) return false;
        return expr.Kind() == SyntaxKind.TrueLiteralExpression;
    }

    private static string? GetDelegateBody(Dictionary<string, ExpressionSyntax> map, string key)
    {
        if (!map.TryGetValue(key, out var expr)) return null;
        return expr switch
        {
            AnonymousMethodExpressionSyntax m => m.Body.ToString(),
            ParenthesizedLambdaExpressionSyntax l => l.Body.ToString(),
            SimpleLambdaExpressionSyntax s => s.Body.ToString(),
            _ => null
        };
    }
}