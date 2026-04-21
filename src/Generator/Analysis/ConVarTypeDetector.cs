namespace RustRcon.Generator.Analysis;

/// <summary>
///     Determines the underlying C# type of a ConVar by inspecting the
///     <c>SetOveride</c> delegate body text.
/// </summary>
public static class ConVarTypeDetector
{
    /// <summary>
    ///     Returns the C# type keyword (<c>int</c>, <c>bool</c>, <c>float</c>, or <c>string</c>)
    ///     based on the conversion call present in <paramref name="setOverrideBody"/>.
    /// </summary>
    /// <remarks>
    ///     Detection is done by matching conversion patterns regardless of whether
    ///     the decompiler emitted extension-method form (<c>str.ToInt()</c>) or
    ///     static-call form (<c>StringExtensions.ToInt(str)</c>).
    /// </remarks>
    public static string Detect(string? setOverrideBody)
    {
        if (string.IsNullOrWhiteSpace(setOverrideBody))
            return "string";

        if (ContainsConversion(setOverrideBody, "ToInt")) return "int";
        if (ContainsConversion(setOverrideBody, "ToBool")) return "bool";
        if (ContainsConversion(setOverrideBody, "ToFloat")) return "float";

        return ContainsConversion(setOverrideBody, "ToLong") ? "long" : "string";
    }

    // Matches both "str.ToInt()" and "StringExtensions.ToInt(str)" forms.
    private static bool ContainsConversion(string body, string methodName)
    {
        return body.Contains($".{methodName}(", StringComparison.Ordinal) ||
               body.Contains($"{methodName}(", StringComparison.Ordinal);
    }
}