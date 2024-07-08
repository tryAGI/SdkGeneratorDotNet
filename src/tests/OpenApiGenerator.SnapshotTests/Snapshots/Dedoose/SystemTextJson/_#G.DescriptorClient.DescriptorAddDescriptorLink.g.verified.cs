﻿//HintName: G.DescriptorClient.DescriptorAddDescriptorLink.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorAddDescriptorLinkArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            ref string resourceId,
            ref string descriptorId,
            global::System.Collections.Generic.IList<global::G.FieldValueDTO> dynamicValues);
        partial void PrepareDescriptorAddDescriptorLinkRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            string resourceId,
            string descriptorId,
            global::System.Collections.Generic.IList<global::G.FieldValueDTO> dynamicValues);
        partial void ProcessDescriptorAddDescriptorLinkResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);
        partial void ProcessDescriptorAddDescriptorLinkResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddDescriptorLink.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="dynamicValues"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> DescriptorAddDescriptorLinkAsync(
            string token,
            string projectId,
            string resourceId,
            string descriptorId,
            global::System.Collections.Generic.IList<global::G.FieldValueDTO> dynamicValues,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/descriptor/adddescriptorlink?projectId={projectId}&resourceId={resourceId}&descriptorId={descriptorId}&{string.Join("&", dynamicValues.Select(static x => $"dynamicValues={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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