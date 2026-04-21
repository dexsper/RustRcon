using System.Text;
using RustRcon.Generator.Analysis.Models;

namespace RustRcon.Generator.Emit;

/// <summary>
///     Generates a <c>.cs</c> command class file for each <see cref="CommandDefinition"/>,
///     grouped under <c>Commands/{Parent}/</c> sub-directories.
/// </summary>
public sealed class CommandEmitter
{
    private readonly string _commandsDir;

    /// <param name="outputDir">Root output directory; files go into <c>Commands/</c>.</param>
    public CommandEmitter(string outputDir)
    {
        _commandsDir = Path.Combine(outputDir, "Commands");
        Directory.CreateDirectory(_commandsDir);
    }

    /// <summary>
    ///     Emits a <c>.cs</c> file for <paramref name="cmd"/> and returns the file path.
    /// </summary>
    public string Emit(CommandDefinition cmd)
    {
        var parentPascal = ToPascalCase(cmd.Parent);
        var namePascal   = ToPascalCase(cmd.Name);
        var className    = $"{parentPascal}{namePascal}Command";

        var ns           = "RustRcon.Generated.Commands";
        var dir          = Path.Combine(_commandsDir, parentPascal);
        Directory.CreateDirectory(dir);

        var sb = new StringBuilder();
        AppendUsings(sb, cmd);
        sb.AppendLine();
        sb.AppendLine($"namespace {ns};");
        sb.AppendLine();

        AppendXmlDoc(sb, cmd.Description, cmd.FullName);
        sb.AppendLine($"/// <remarks>Full RCON name: <c>{cmd.FullName}</c></remarks>");

        AppendClassDeclaration(sb, cmd, className);
        sb.AppendLine("{");
        sb.AppendLine($"    /// <summary>Full dotted RCON name.</summary>");
        sb.AppendLine($"    public const string CommandFullName = \"{cmd.FullName}\";");
        sb.AppendLine();

        AppendFactoryMethods(sb, cmd, className);

        sb.AppendLine("}");

        var path = Path.Combine(dir, $"{className}.cs");
        File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        return path;
    }

    private static void AppendUsings(StringBuilder sb, CommandDefinition cmd)
    {
        sb.AppendLine("using RustRcon.Types;");
        sb.AppendLine("using RustRcon.Types.Commands.Base;");

        if (cmd.Kind == CommandKind.CallWithReturn &&
            cmd.ReturnTypeName is not null &&
            cmd.ReturnTypeName != "TextTableResponse" &&
            !IsPrimitiveOrSystem(cmd.ReturnTypeName))
        {
            sb.AppendLine("using RustRcon.Generated.Dtos;");
        }
    }

    private static void AppendXmlDoc(StringBuilder sb, string description, string fullName)
    {
        if (!string.IsNullOrWhiteSpace(description))
        {
            sb.AppendLine($"/// <summary>{EscapeXml(description)}</summary>");
        }
        else
        {
            sb.AppendLine($"/// <summary>RCON command: <c>{fullName}</c>.</summary>");
        }
    }

    private static void AppendClassDeclaration(
        StringBuilder sb, CommandDefinition cmd, string className)
    {
        var baseClass = cmd.Kind switch
        {
            CommandKind.ConVar                                                    => $"BaseConVarCommand<{cmd.ConVarTypeName ?? "string"}>",
            CommandKind.CallWithReturn when cmd.ReturnTypeName == "TextTableResponse" => "BaseTextTableCommand",
            CommandKind.CallWithReturn                                            => $"BaseCallCommand<{FormatReturnType(cmd.ReturnTypeName)}>",
            _                                                                     => "BaseCommand"
        };

        sb.AppendLine($"public sealed class {className} : {baseClass}");
    }

    private static void AppendFactoryMethods(
        StringBuilder sb, CommandDefinition cmd, string className)
    {
        switch (cmd.Kind)
        {
            case CommandKind.ConVar:
                AppendConVarFactories(sb, cmd, className);
                break;

            case CommandKind.CallWithReturn:
            case CommandKind.CallVoid:
                AppendSimpleCreate(sb, cmd, className, cmd.Parameters);
                break;

            case CommandKind.CallWithSteamId:
            case CommandKind.CallWithParams:
                AppendSimpleCreate(sb, cmd, className, cmd.Parameters);
                break;
        }
    }

    private static void AppendConVarFactories(
        StringBuilder sb, CommandDefinition cmd, string className)
    {
        var typeName = cmd.ConVarTypeName ?? "string";

        sb.AppendLine($"    /// <summary>Reads the current value of <c>{cmd.FullName}</c>.</summary>");
        sb.AppendLine($"    public static {className} CreateGet()");
        sb.AppendLine("    {");
        sb.AppendLine($"        var cmd = CreatePackage<{className}>();");
        sb.AppendLine($"        cmd.Content = CommandFullName;");
        sb.AppendLine("        return cmd;");
        sb.AppendLine("    }");
        sb.AppendLine();
        sb.AppendLine($"    /// <summary>Sets <c>{cmd.FullName}</c> to <paramref name=\"value\"/>.</summary>");
        sb.AppendLine($"    public static {className} CreateSet({typeName} value)");
        sb.AppendLine("    {");
        sb.AppendLine($"        var cmd = CreatePackage<{className}>();");
        sb.AppendLine($"        cmd.Content = $\"{{CommandFullName}} {{value}}\";");
        sb.AppendLine("        return cmd;");
        sb.AppendLine("    }");
    }

    private static void AppendSimpleCreate(
        StringBuilder sb, CommandDefinition cmd, string className,
        IReadOnlyList<CommandParameter> parameters)
    {
        var positional = parameters.Where(p => !p.IsFlag).ToList();
        var flags      = parameters.Where(p =>  p.IsFlag).ToList();

        var sigParts = positional.Select(p => $"{p.TypeName} {p.ParameterName}")
            .Concat(flags.Select(f => $"bool {f.ParameterName} = false"));
        var paramList = string.Join(", ", sigParts);

        sb.AppendLine($"    /// <summary>Creates a new <see cref=\"{className}\"/> command.</summary>");
        sb.AppendLine($"    public static {className} Create({paramList})");
        sb.AppendLine("    {");
        sb.AppendLine($"        var cmd = CreatePackage<{className}>();");

        if (flags.Count == 0)
        {
            // Simple case: only positional args (or none).
            if (positional.Count == 0)
                sb.AppendLine($"        cmd.Content = CommandFullName;");
            else
            {
                var vals = string.Join(" ", positional.Select(p => $"{{{p.ParameterName}}}"));
                sb.AppendLine($"        cmd.Content = $\"{{CommandFullName}} {vals}\";");
            }
        }
        else
        {
            // Has flags: build content with a StringBuilder so absent flags are omitted.
            sb.AppendLine($"        var content = new System.Text.StringBuilder(CommandFullName);");
            foreach (var p in positional)
                sb.AppendLine($"        content.Append($\" {{{p.ParameterName}}}\");");
            foreach (var f in flags)
                sb.AppendLine($"        if ({f.ParameterName}) content.Append(\" {f.FlagName}\");");
            sb.AppendLine($"        cmd.Content = content.ToString();");
        }

        sb.AppendLine("        return cmd;");
        sb.AppendLine("    }");
    }

    private static string FormatReturnType(string? typeName) => typeName ?? "string";

    private static bool IsPrimitiveOrSystem(string typeName)
    {
        var t = typeName.TrimEnd('[', ']');
        return t is "string" or "int" or "long" or "float" or "double" or "bool" or "ulong"
                  or "object" or "String" or "Int32" or "Int64" or "Single" or "Double"
                  or "Boolean" or "UInt64"
                  or "TextTableResponse";
    }

    private static string ToPascalCase(string s)
    {
        if (string.IsNullOrEmpty(s)) return s;
        return string.Concat(
            s.Split(['_', '-', '.'])
             .Select(w => w.Length > 0
                 ? char.ToUpperInvariant(w[0]) + w[1..]
                 : w));
    }

    private static string EscapeXml(string raw) =>
        raw.Replace("\r\n", " ")
           .Replace("\r", " ")
           .Replace("\n", " ")
           .Replace("&", "&amp;")
           .Replace("<", "&lt;")
           .Replace(">", "&gt;")
           .Trim();
}
