﻿//HintName: G.AnnotationQueuesClient.DeleteRunFromAnnotationQueue.g.cs

#nullable enable

namespace G
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareDeleteRunFromAnnotationQueueArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid queueId,
            ref global::System.Guid queueRunId);
        partial void PrepareDeleteRunFromAnnotationQueueRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid queueId,
            global::System.Guid queueRunId);
        partial void ProcessDeleteRunFromAnnotationQueueResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteRunFromAnnotationQueueResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Run From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="queueRunId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteResponse> DeleteRunFromAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.Guid queueRunId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteRunFromAnnotationQueueArguments(
                httpClient: _httpClient,
                queueId: ref queueId,
                queueRunId: ref queueRunId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/annotation-queues/{queueId}/runs/{queueRunId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteRunFromAnnotationQueueRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                queueId: queueId,
                queueRunId: queueRunId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteRunFromAnnotationQueueResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteRunFromAnnotationQueueResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}