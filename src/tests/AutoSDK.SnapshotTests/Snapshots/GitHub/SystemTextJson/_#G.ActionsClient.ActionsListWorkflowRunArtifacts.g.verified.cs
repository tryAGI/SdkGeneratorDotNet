﻿//HintName: G.ActionsClient.ActionsListWorkflowRunArtifacts.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsListWorkflowRunArtifactsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int runId,
            ref int? perPage,
            ref int? page,
            ref string? name);
        partial void PrepareActionsListWorkflowRunArtifactsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int runId,
            int? perPage,
            int? page,
            string? name);
        partial void ProcessActionsListWorkflowRunArtifactsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsListWorkflowRunArtifactsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List workflow run artifacts<br/>
        /// Lists artifacts for a workflow run.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsListWorkflowRunArtifactsResponse> ActionsListWorkflowRunArtifactsAsync(
            string owner,
            string repo,
            int runId,
            int? perPage = 30,
            int? page = 1,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActionsListWorkflowRunArtifactsArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                runId: ref runId,
                perPage: ref perPage,
                page: ref page,
                name: ref name);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/actions/runs/{runId}/artifacts",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("name", name) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsListWorkflowRunArtifactsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                runId: runId,
                perPage: perPage,
                page: page,
                name: name);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsListWorkflowRunArtifactsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActionsListWorkflowRunArtifactsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ActionsListWorkflowRunArtifactsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}