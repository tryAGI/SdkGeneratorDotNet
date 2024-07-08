﻿//HintName: G.TagClient.TagAddExcerptTagApplications.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagAddExcerptTagApplicationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string userId,
            ref string projectId,
            ref string resourceId,
            ref string excerptId,
            global::System.Collections.Generic.IList<global::G.TagAppSimple> tagApps);
        partial void PrepareTagAddExcerptTagApplicationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string userId,
            string projectId,
            string resourceId,
            string excerptId,
            global::System.Collections.Generic.IList<global::G.TagAppSimple> tagApps);
        partial void ProcessTagAddExcerptTagApplicationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagAddExcerptTagApplicationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddExcerptTagApplications.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="tagApps"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> TagAddExcerptTagApplicationsAsync(
            string token,
            string userId,
            string projectId,
            string resourceId,
            string excerptId,
            global::System.Collections.Generic.IList<global::G.TagAppSimple> tagApps,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTagAddExcerptTagApplicationsArguments(
                httpClient: _httpClient,
                token: ref token,
                userId: ref userId,
                projectId: ref projectId,
                resourceId: ref resourceId,
                excerptId: ref excerptId,
                tagApps: tagApps);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/tag/addexcerpttagapplications?userId={userId}&projectId={projectId}&resourceId={resourceId}&excerptId={excerptId}&{string.Join("&", tagApps.Select(static x => $"tagApps={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTagAddExcerptTagApplicationsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                userId: userId,
                projectId: projectId,
                resourceId: resourceId,
                excerptId: excerptId,
                tagApps: tagApps);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTagAddExcerptTagApplicationsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTagAddExcerptTagApplicationsResponseContent(
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
    }
}