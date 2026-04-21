namespace RustRcon.Generator.Analysis.Models;

/// <summary>Metadata for a C# enum extracted from the decompiled game assembly.</summary>
public sealed class EnumDefinition
{
    /// <summary>Simple name, e.g. <c>UserGroup</c>.</summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>Namespace the enum will be placed in inside the generated project.</summary>
    public string Namespace { get; init; } = "RustRcon.Generated.Dtos";

    /// <summary>Ordered list of member names and their explicit values (when present).</summary>
    public List<(string Name, long? Value)> Members { get; init; } = [];
}
