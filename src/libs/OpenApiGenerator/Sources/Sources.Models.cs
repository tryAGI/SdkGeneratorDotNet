using H.Generators.Extensions;
using OpenApiGenerator.Models;

namespace OpenApiGenerator;

internal static partial class Sources
{
    public static string GenerateModel(
        Model model,
        CancellationToken cancellationToken = default)
    {
        return model.Style switch
        {
            ModelStyle.Class => GenerateClassModel(model, cancellationToken),
            ModelStyle.Enumeration => GenerateEnumerationModel(model, cancellationToken),
            _ => throw new NotSupportedException($"Model style {model.Style} is not supported."),
        };
    }
    
    public static string GenerateClassModel(
        Model model,
        CancellationToken cancellationToken = default)
    {
        var parents = model.Parent != null
            ? model.Parent.Split('.')
            : Array.Empty<string>();
        
        return $@"
#nullable enable

namespace {model.Namespace}
{{
    {(model.Parent != null
        ? $@"
    public sealed partial class {model.Parent}
    {{"
        : " ")}
{GenerateClassModel(model, level: parents.Length, cancellationToken: cancellationToken)}
    {(model.Parent != null
        ? @"
    }"
        : " ")}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateEnumerationModel(
        Model model,
        CancellationToken cancellationToken = default)
    {
        return $@"
#nullable enable

namespace {model.Namespace}
{{
    {model.Summary.ToXmlDocumentationSummary(level: 4)}
    [global::System.Runtime.Serialization.DataContract]
    public enum {model.Name}
    {{
{model.Properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        [global::System.Runtime.Serialization.EnumMember(Value=""{property.Id}"")]
        {property.Name},
").Inject()}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateClassModel(
        Model model,
        int level,
        CancellationToken cancellationToken = default)
    {
        return $@" 
    {model.Summary.ToXmlDocumentationSummary(level: 4)}
    public sealed partial class {model.Name}
    {{
{model.Properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        [global::System.Text.Json.Serialization.JsonPropertyName(""{property.Id}"")]
        public{(property.IsRequired ? " required" : "")} {property.Type} {property.Name} {{ get; set; }}{(property.IsRequired || property.DefaultValue == null ? string.Empty : $" = {property.DefaultValue};")}
").Inject()}

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties {{ get; set; }} = new global::System.Collections.Generic.Dictionary<string, object>();
    }}".AddIndent(level: level);
    }
}