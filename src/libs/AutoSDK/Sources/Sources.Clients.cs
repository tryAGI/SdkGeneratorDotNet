using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateConstructors(
        EndPoint endPoint)
    {
        var serializer = endPoint.Settings.JsonSerializerType.GetSerializer();
        var hasOptions = string.IsNullOrWhiteSpace(endPoint.Settings.JsonSerializerContext);
        
        return $@"
#nullable enable

namespace {endPoint.Namespace}
{{
    {(endPoint.Summary + "\nIf no httpClient is provided, a new one will be created.\nIf no baseUri is provided, the default baseUri from OpenAPI spec will be used.").ToXmlDocumentationSummary()}
    public sealed partial class {endPoint.ClassName} : global::System.IDisposable
    {{
        {endPoint.BaseUrlSummary.ToXmlDocumentationSummary(level: 8)}
        public const string BaseUrl = ""{endPoint.BaseUrl}"";

        private readonly global::System.Net.Http.HttpClient _httpClient;

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
{(hasOptions ? $@" 
        public {serializer.GetOptionsType()} JsonSerializerOptions {{ get; set; }}{(
            endPoint.Id == "MainConstructor"
                ? $" = {serializer.CreateDefaultSettings(endPoint.Converters)};"
                : $" = new {serializer.GetOptionsType()}();")}" : $@" 
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext {{ get; set; }} = global::{endPoint.Settings.JsonSerializerContext}.Default;")}

{(endPoint.Properties.Length != 0 ? "\n" + endPoint.Properties.Select(x => $@"
        {x.Summary.ToXmlDocumentationSummary(level: 8)}
        public {x.Type.CSharpType} {x.Name} => new {x.Type.CSharpType}(_httpClient)
        {{
            {(hasOptions
                ? "JsonSerializerOptions = JsonSerializerOptions,"
                : "JsonSerializerContext = JsonSerializerContext,")}
        }};
").Inject() : " ")}

        /// <summary>
        /// Creates a new instance of the {endPoint.ClassName}.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name=""httpClient""></param>
        /// <param name=""baseUri""></param>{(hasOptions ? @"
        /// <param name=""jsonSerializerOptions""></param>" : " ")}
        public {endPoint.ClassName}(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {{
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);

            Initialized(_httpClient);
        }}

        /// <inheritdoc/>
        public void Dispose()
        {{
            _httpClient.Dispose();
        }}

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}