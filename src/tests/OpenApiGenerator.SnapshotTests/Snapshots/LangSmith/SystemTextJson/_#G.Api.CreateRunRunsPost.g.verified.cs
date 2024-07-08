﻿//HintName: G.Api.CreateRunRunsPost.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCreateRunRunsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.RunCreateSchemaExtended request);
        partial void PrepareCreateRunRunsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.RunCreateSchemaExtended request);
        partial void ProcessCreateRunRunsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRunRunsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Run<br/>
        /// Create a new run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> CreateRunRunsPostAsync(
            global::G.RunCreateSchemaExtended request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateRunRunsPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/runs", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateRunRunsPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateRunRunsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateRunRunsPostResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Run<br/>
        /// Create a new run.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputs"></param>
        /// <param name="runType"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="error"></param>
        /// <param name="executionOrder"></param>
        /// <param name="serialized"></param>
        /// <param name="outputs"></param>
        /// <param name="parentRunId"></param>
        /// <param name="manifestId"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="childRuns"></param>
        /// <param name="referenceExampleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> CreateRunRunsPostAsync(
            string name,
            global::G.RunTypeEnum runType,
            global::System.AnyOf<object?, global::G.CreateChatCompletionRequest?, global::G.CreateCompletionRequest?>? inputs = default,
            global::System.DateTime startTime = default,
            global::System.DateTime endTime = default,
            object? extra = default,
            string? error = default,
            int executionOrder = 1,
            object? serialized = default,
            global::System.AnyOf<object?, global::G.CreateChatCompletionResponse?, global::G.CreateCompletionResponse?>? outputs = default,
            string? parentRunId = default,
            string? manifestId = default,
            global::System.Collections.Generic.IList<object?>? events = default,
            global::System.Collections.Generic.IList<string?>? tags = default,
            string? id = default,
            string? sessionId = default,
            string? sessionName = default,
            global::System.Collections.Generic.IList<global::G.RunCreateSchema>? childRuns = default,
            string? referenceExampleId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.RunCreateSchemaExtended
            {
                Name = name,
                Inputs = inputs,
                RunType = runType,
                StartTime = startTime,
                EndTime = endTime,
                Extra = extra,
                Error = error,
                ExecutionOrder = executionOrder,
                Serialized = serialized,
                Outputs = outputs,
                ParentRunId = parentRunId,
                ManifestId = manifestId,
                Events = events,
                Tags = tags,
                Id = id,
                SessionId = sessionId,
                SessionName = sessionName,
                ChildRuns = childRuns,
                ReferenceExampleId = referenceExampleId,
            };

            return await CreateRunRunsPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}