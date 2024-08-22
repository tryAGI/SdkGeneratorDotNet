﻿//HintName: G.WorkspacesClient.DeleteTagValue.g.cs

#nullable enable

namespace G
{
    public partial class WorkspacesClient
    {
        partial void PrepareDeleteTagValueArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string tagKeyId,
            ref string tagValueId);
        partial void PrepareDeleteTagValueRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string tagKeyId,
            string tagValueId);
        partial void ProcessDeleteTagValueResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteTagValueResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Tag Value
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeleteTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdDeleteResponse> DeleteTagValueAsync(
            string tagKeyId,
            string tagValueId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteTagValueArguments(
                httpClient: _httpClient,
                tagKeyId: ref tagKeyId,
                tagValueId: ref tagValueId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/workspaces/current/tag-keys/{tagKeyId}/tag-values/{tagValueId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteTagValueRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                tagKeyId: tagKeyId,
                tagValueId: tagValueId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteTagValueResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteTagValueResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeleteTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdDeleteResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}